namespace Comic.Application.UrlChapterImageComics
{
    public interface IUrlChapterImageComicService
    {
        Task<List<string>> GetByChapterComicId(int id);

        Task<List<string>> GetByChapterComicSeoAlias(string seoAlias);
    }
}
