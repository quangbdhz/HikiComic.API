using Comic.ViewModels.ChapterComics;

namespace Comic.Application.ChapterComics
{
    public interface IChapterComicService
    {
        Task<List<ChapterComicViewModel>> GetById(int idComic);

        Task<List<ChapterComicViewModel>> GetBySeoAlias(string seoAliasComic);
    }
}
