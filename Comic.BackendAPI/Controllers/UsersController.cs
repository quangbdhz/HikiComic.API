using Comic.Application.MailConfirms;
using Comic.Application.Users;
using Comic.BackendAPI.Models;
using Comic.Utilities.Constants;
using Comic.ViewModels.Common;
using Comic.ViewModels.MailConfirms;
using Comic.ViewModels.Users;
using Comic.ViewModels.Users.UserDataRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Cryptography;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMailConfirmService _emailConfirmService;

        public UsersController(IUserService userService, IMailConfirmService emailConfirmService)
        {
            _userService = userService;
            _emailConfirmService = emailConfirmService;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Login(request);

            if (string.IsNullOrEmpty(result.Message))
            {
                return BadRequest("Token Is Null");
            }

            var refreshToken = GenerateRefreshToken();
            int outputRefreshToken = await SetRefreshToken(refreshToken, result.ResultObj.Id);

            if (outputRefreshToken == 1)
                return Ok(result);

            return BadRequest("Exception");
        }

        [HttpPost("{userId}/RefreshToken")]
        public async Task<ActionResult<string>> RefreshToken(Guid userId)
        {
            var refreshToken = Request.Cookies["refreshToken"];

            var result = await _userService.RefreshToken(userId, refreshToken);

            var newRefreshToken = GenerateRefreshToken();

            int outputRefreshToken = await SetRefreshToken(newRefreshToken, userId);
            if(outputRefreshToken == 1)
                return Ok(result);

            return BadRequest("Exception");
        }

        [NonAction]
        private RefreshToken GenerateRefreshToken()
        {
            var refreshToken = new RefreshToken
            {
                Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                Expires = DateTime.Now.AddDays(7),
                Created = DateTime.Now
            };

            return refreshToken;
        }

        [NonAction]
        private async Task<int> SetRefreshToken(RefreshToken newRefreshToken, Guid userId)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = newRefreshToken.Expires   
            };
            Response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);

            await _userService.SetRefreshToken(userId, newRefreshToken.Token, newRefreshToken.Created, newRefreshToken.Expires);

            return 1;
        }

        //[NonAction]
        //private string ipAddress()
        //{
        //    if (Request.Headers.ContainsKey("X-Forwarded-For"))
        //        return Request.Headers["X-Forwarded-For"];
        //    else
        //        return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        //}

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _userService.GetById(id);
            return Ok(user);
        }

        [HttpGet("GetByEmail/{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            email = WebUtility.UrlDecode(email);
            var user = await _userService.GetByEmail(email);
            return Ok(user);
        }

        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Register(request);

            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }

            MailConfirmViewModel mailConfirmViewModel = this.GetMailObject(result.ResultObj);
            await _emailConfirmService.SendMail(mailConfirmViewModel);

            return Ok(new { Message = MessageConstants.VerifyMail });
        }   

        [NonAction]
        public MailConfirmViewModel GetMailObject(UserViewModel userViewModel)
        {
            MailConfirmViewModel mailConfirmViewModel = new MailConfirmViewModel();
            mailConfirmViewModel.Subject = "Mail Confirmation";
            mailConfirmViewModel.Body = _emailConfirmService.GetMailBody(userViewModel);
            mailConfirmViewModel.ToMailIds = new List<string>()
            {
                userViewModel.Email
            };
            return mailConfirmViewModel;
        }

        [HttpPost("ConfirmMail")]
        [AllowAnonymous]
        public async Task<ApiResult<bool>> ConfirmMail(string userName)
        {
            var result = await _userService.ConfirmMail(userName);
            return result;
        }

        [HttpPost("Update")]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Update(request);

            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }

            return Ok(result.Message);

        }

        [HttpDelete("Delete/{userId}")]
        public async Task<IActionResult> Delete(Guid userId)
        {
            var result = await _userService.Delete(userId);
            return Ok(result.Message);
        }

        [HttpGet("UserPaging")]
        public async Task<IActionResult> UserPaging([FromQuery] PagingRequestBase request)
        {
            var comicStrips = await _userService.GetUserPaging(request);
            return Ok(comicStrips);
        }

    }
}
