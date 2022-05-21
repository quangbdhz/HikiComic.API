using Comic.Data.Entities;
using Comic.ViewModels.Common;
using Comic.ViewModels.Users;
using Comic.ViewModels.Users.UserDataRequest;

namespace Comic.Application.Users
{
    public interface IUserService
    {
        Task<ApiResult<UserViewModel>> Login(LoginRequest request);

        Task<string> CreateToken(AppUser user);

        Task<List<UserViewModel>> GetUserPaging(PagingRequestBase request);

        Task<ApiResult<UserViewModel>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(UserUpdateRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<UserViewModel>> GetByEmail(string email);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> ConfirmMail(string userName);

        Task<ApiResult<bool>> RefreshToken(Guid userId, string? refreshToken);

        Task<ApiResult<bool>> SetRefreshToken(Guid userId, string refreshToken, DateTime tokenCreated, DateTime tokenExpires);
    }
}
