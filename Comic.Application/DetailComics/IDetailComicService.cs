using Comic.ViewModels.Common;
using Comic.ViewModels.DetailComics;

namespace Comic.Application.DetailComics
{
    public interface IDetailComicService
    {
        Task<DetailComicViewModel> GetById(int id);

        Task<DetailComicViewModel> GetBySeoAlias(string seoAlias);

        Task<DetailComicViewModel> GetById(Guid userId, int id);

        Task<DetailComicViewModel> GetBySeoAlias(Guid userId, string seoAlias);

        Task<ApiResult<bool>> UpdateUserFollowComic(Guid userId, int comicId);
    }
}
