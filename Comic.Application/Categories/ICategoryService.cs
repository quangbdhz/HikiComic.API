using Comic.ViewModels.Categories;

namespace Comic.Application.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll();

        Task<CategoryViewModel> GetById(int id);

        Task<CategoryViewModel> GetBySeoAlias(string seoAlias);
    }
}
