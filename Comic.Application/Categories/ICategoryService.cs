using Comic.ViewModels.Categories;
using Comic.ViewModels.Categories.CategoryDataRequest;
using Comic.ViewModels.Common;

namespace Comic.Application.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll();

        Task<CategoryViewModel> GetById(int id);

        Task<CategoryViewModel> GetBySeoAlias(string seoAlias);

        Task<List<CategoryViewModel>> GetCategoryShowHome();

        Task<List<CategoryViewModel>> GetBySize(int number);

        Task<ApiResult<bool>> AddCategrory(AddCategoryRequest addCategoryRequest);

        Task<ApiResult<bool>> UpdateCategory(UpdateCategoryRequest updateCategoryRequest);

        Task<ApiResult<bool>> DeleteCategory(int categoryId);
    }
}
