using Comic.Data.EF;
using Comic.Data.Entities;
using Comic.ViewModels.Categories;
using Comic.ViewModels.Categories.CategoryDataRequest;
using Comic.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Comic.Application.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ComicDbContext _context;

        public CategoryService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<bool>> AddCategrory(AddCategoryRequest addCategoryRequest)
        {
            var checkCategory = await _context.DetailCategories.SingleOrDefaultAsync(x => x.NameCategory == addCategoryRequest.NameCategory && x.SeoAlias == addCategoryRequest.SeoAlias);
            if (checkCategory != null)
            {
                return new ApiErrorResult<bool>("Category Is Available");
            }

            bool checkParentId = await IsCheckParentIdInCategory(addCategoryRequest.ParentId);
            if (checkParentId == false)
                return new ApiErrorResult<bool>("ParentId Is Not Available In List Categories");

            var category = new Category() { ParentId = addCategoryRequest.ParentId, DateCreated = DateTime.Now, IsActive = true, IsShowHome = addCategoryRequest.IsShowHome, UrlImageCategory = addCategoryRequest.UrlImageCategory };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            var detailCategory = new DetailCategory() { CategoryId = category.Id, NameCategory = addCategoryRequest.NameCategory, SeoAlias = addCategoryRequest.SeoAlias, SeoDescription = addCategoryRequest.SeoDescription, SeoTitle = addCategoryRequest.SeoTitle };
            await _context.DetailCategories.AddAsync(detailCategory);
            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>("Add Category Is Success");

        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from c in _context.Categories where c.IsActive == true join dc in _context.DetailCategories on c.Id equals dc.CategoryId select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory, IsActive = x.c.IsActive }).ToListAsync();

        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            var query = from c in _context.Categories where c.IsActive == true join dc in _context.DetailCategories on c.Id equals dc.CategoryId where c.Id == id select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory, IsActive = x.c.IsActive }).FirstOrDefaultAsync();

        }

        public async Task<CategoryViewModel> GetBySeoAlias(string seoAlias)
        {
            seoAlias = WebUtility.UrlDecode(seoAlias);

            var query = from c in _context.Categories where c.IsActive == true join dc in _context.DetailCategories on c.Id equals dc.CategoryId where dc.SeoAlias == seoAlias select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory }).FirstOrDefaultAsync();

        }

        public async Task<List<CategoryViewModel>> GetBySize(int number)
        {
            var query = from c in _context.Categories where c.IsActive == true join dc in _context.DetailCategories on c.Id equals dc.CategoryId orderby c.DateCreated descending select new  { c, dc };

            if(number > 0)
            {
                var categories = await query.Take(number).Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory, IsActive = x.c.IsActive }).ToListAsync();
                return categories;
            }
            return null;
        }

        public async Task<List<CategoryViewModel>> GetCategoryShowHome()
        {
            var query = from c in _context.Categories where c.IsActive == true join dc in _context.DetailCategories on c.Id equals dc.CategoryId where c.IsShowHome == true select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory, IsActive = x.c.IsActive }).ToListAsync();
        }

        public async Task<ApiResult<bool>> UpdateCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            var checkCategory = await _context.Categories.SingleOrDefaultAsync(x => x.Id == updateCategoryRequest.CategoryId);
            if (checkCategory == null)
                return new ApiErrorResult<bool>("Category Is Not Available");

            bool checkParentId = await IsCheckParentIdInCategory(updateCategoryRequest.ParentId);
            if (checkParentId == false)
                return new ApiErrorResult<bool>("ParentId Is Not Available In List Categories");

            checkCategory.ParentId = updateCategoryRequest.ParentId != 0 && updateCategoryRequest.ParentId != null ? updateCategoryRequest.ParentId : null;
            checkCategory.UrlImageCategory = updateCategoryRequest.UrlImageCategory;
            checkCategory.IsShowHome = updateCategoryRequest.IsShowHome;
            await _context.SaveChangesAsync();

            var oldDetailCategory = await _context.DetailCategories.SingleOrDefaultAsync(x => x.CategoryId == updateCategoryRequest.CategoryId);
            if(oldDetailCategory != null)
            {
                oldDetailCategory.SeoDescription = updateCategoryRequest.SeoDescription;
                oldDetailCategory.SeoTitle = updateCategoryRequest.SeoTitle;
                await _context.SaveChangesAsync();

                return new ApiSuccessResult<bool>("Update Category Is Suscess");
            }

            return new ApiErrorResult<bool>("DetailCategory Is Not Available");
        }

        public async Task<bool> IsCheckParentIdInCategory(int? parentId)
        {
            if (parentId == null || parentId == 0)
                return true;

            var category = await _context.Categories.SingleOrDefaultAsync(x => x.Id == parentId);
            if (category == null)
                return false;
            return true;
        }

        public async Task<ApiResult<bool>> DeleteCategory(int categoryId)
        {
            var checkCategory = await _context.Categories.SingleOrDefaultAsync(x => x.Id == categoryId);
            if (checkCategory == null)
                return new ApiErrorResult<bool>("Category Is Not Available");

            checkCategory.IsActive = !checkCategory.IsActive;
            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>("Delete Category Is Success");
        }

        public async Task<PagedResult<CategoryViewModel>> GetAllPagingManager(PagingRequestBase request)
        {
            var query = from c in _context.Categories join dc in _context.DetailCategories on c.Id equals dc.CategoryId select new { c, dc };
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                 .Select(x => new CategoryViewModel()
                 {
                     Id = x.c.Id,
                     Name = x.dc.NameCategory,
                     SeoAlias = x.dc.SeoAlias,
                     ParentId = x.c.ParentId,
                     UrlImageCategory = x.c.UrlImageCategory,
                     IsActive = x.c.IsActive
                 }).ToListAsync();

            var pagedResult = new PagedResult<CategoryViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };

            return pagedResult;

        }
    }
}
