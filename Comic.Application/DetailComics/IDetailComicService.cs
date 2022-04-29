using Comic.ViewModels.DetailComics;

namespace Comic.Application.DetailComics
{
    public interface IDetailComicService
    {
        Task<DetailComicViewModel> GetById(int id);

        Task<DetailComicViewModel> GetBySeoAlias(string seoAlias);
    }
}
