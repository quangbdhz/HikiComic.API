using Comic.Data.EF;
using Comic.Data.Entities;
using Comic.Utilities.Constants;
using Comic.ViewModels.Common;
using Comic.ViewModels.Users;
using Comic.ViewModels.Users.UserDataRequest;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Comic.Application.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _config;
        private readonly ComicDbContext _context;

        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IConfiguration config, ComicDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
            _context = context;
        }

        public async Task<ApiResult<string>> Authencate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) 
                return new ApiErrorResult<string>("User Is Not Available");

            if (user.IsActive == false)
                return new ApiErrorResult<string>("User Is Locked");

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>("Incorrect login");
            }

            if (user.EmailConfirmed == false)
                return new ApiErrorResult<string>(MessageConstants.UserCreatedverifyMail);

            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.Id.ToString()),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name, request.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
        }

        public async Task<ApiResult<bool>> ConfirmMail(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if(user != null)
            {
                user.EmailConfirmed = true;
                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return new ApiSuccessResult<bool>();
                }
                return new ApiErrorResult<bool>(MessageConstants.UserConfirmMailError);
            }
            return new ApiErrorResult<bool>("User Is Not Available");
        }

        public async Task<ApiResult<bool>> Delete(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return new ApiErrorResult<bool>("User Is Not Available");

            user.IsActive = !user.IsActive;

            await _context.SaveChangesAsync();

            if (!user.IsActive)
                return new ApiSuccessResult<bool>("Delete User Is Success");
            return new ApiSuccessResult<bool>("Activated User");

        }

        public async Task<ApiResult<UserViewModel>> GetByEmail(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return new ApiErrorResult<UserViewModel>("User không tồn tại");
            }

            if (user.IsActive == false)
            {
                return new ApiErrorResult<UserViewModel>("User Is Not Active");
            }

            var gender = await _context.Genders.SingleOrDefaultAsync(x => x.Id == user.GenderId);

            var userVm = new UserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                FirstName = user.FirstName,
                Dob = user.Dob,
                LastName = user.LastName,
                IsActive = user.IsActive
            };

            if (gender != null)
            {
                userVm.Gender = gender.NameGender;
            }

            return new ApiSuccessResult<UserViewModel>(userVm);
        }

        public async Task<ApiResult<UserViewModel>> GetById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<UserViewModel>("User không tồn tại");
            }

            if (user.IsActive == false)
            {
                return new ApiErrorResult<UserViewModel>("User Is Not Active");
            }

            var gender = await _context.Genders.SingleOrDefaultAsync(x => x.Id == user.GenderId);

            var userVm = new UserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                FirstName = user.FirstName,
                Dob = user.Dob,
                LastName = user.LastName,
                IsActive = user.IsActive
            };

            if(gender != null)
            {
                userVm.Gender = gender.NameGender;
            }

            return new ApiSuccessResult<UserViewModel>(userVm);
        }

        public async Task<List<UserViewModel>> GetUserPaging(PagingRequestBase request)
        {
            var query = from c in _context.Users join g in _context.Genders on c.GenderId equals g.Id select new { c , g };

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new UserViewModel()
            {
                Id = x.c.Id,
                Email = x.c.Email,
                PhoneNumber = x.c.PhoneNumber,
                UserName = x.c.UserName,
                FirstName = x.c.FirstName,
                Dob = x.c.Dob,
                LastName = x.c.LastName,
                Gender = x.g.NameGender,
                IsActive = x.c.IsActive
            }).ToListAsync();

            return data;
        }

        public async Task<ApiResult<UserViewModel>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {
                return new ApiErrorResult<UserViewModel>("Tài khoản đã tồn tại");
            }
            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                return new ApiErrorResult<UserViewModel>("Emai đã tồn tại");
            }

            user = new AppUser()
            {
                Dob = request.Dob,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                GenderId = request.GenderId,
                EmailConfirmed = false
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                UserViewModel userViewModel = new UserViewModel() { Id = user.Id, Dob = user.Dob, Email = user.Email, UserName = user.UserName, FirstName = user.FirstName, Gender = "", LastName = user.LastName, PhoneNumber = user.PhoneNumber  };
                return new ApiSuccessResult<UserViewModel>() { ResultObj = userViewModel };
            }

            return new ApiErrorResult<UserViewModel>("Đăng ký không thành công");
        }


        public async Task<ApiResult<bool>> Update(UserUpdateRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.Id.ToString());
            if (user == null)
                return new ApiErrorResult<bool>("User Is Not Available");

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.PhoneNumber = request.PhoneNumber;
            user.GenderId = request.GenderId;
            user.Dob = request.Dob;

            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>("Update User Is Success");

        }
    }
}
