using Comic.ViewModels.ChapterComics;
using Comic.ViewModels.Common;

namespace Comic.Application.ChapterComics
{
    public interface IChapterComicService
    {
        Task<List<ChapterComicViewModel>> GetByComicId(int idComic);

        Task<List<ChapterComicViewModel>> GetByComicSeoAlias(string seoAliasComic);

        Task<ApiResult<bool>> AddViewCount(string seoAliasChapter);
    }
}
