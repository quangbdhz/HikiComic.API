using Comic.ViewModels.Common;
using Comic.ViewModels.Genders;

namespace Comic.Application.Genders
{
    public interface IGenderService
    {
        Task<ApiResult<GenderViewModel>> GetById(int idGender);

        Task<List<GenderViewModel>> GetAll();
    }
}
