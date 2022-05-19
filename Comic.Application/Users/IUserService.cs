using Comic.ViewModels.Common;
using Comic.ViewModels.Users;
using Comic.ViewModels.Users.UserDataRequest;

namespace Comic.Application.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);

        Task<ApiResult<UserViewModel>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<UserViewModel>> GetByEmail(string email);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> ConfirmMail(string userName);

    }
}
