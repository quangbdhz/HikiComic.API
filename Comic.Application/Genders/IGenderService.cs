using Comic.ViewModels.Common;

namespace Comic.Application.Genders
{
    public interface IGenderService
    {
        Task<ApiResult<int>> GetById(int idGender);
    }
}
