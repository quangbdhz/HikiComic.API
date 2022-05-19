using Comic.ViewModels.ChapterComics;

namespace Comic.Application.ChapterComics
{
    public interface IChapterComicService
    {
        Task<List<ChapterComicViewModel>> GetByComicId(int idComic);

        Task<List<ChapterComicViewModel>> GetByComicSeoAlias(string seoAliasComic);
    }
}
