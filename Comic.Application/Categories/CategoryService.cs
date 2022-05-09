using Comic.Data.EF;
using Comic.ViewModels.Categories;
using Microsoft.EntityFrameworkCore;

namespace Comic.Application.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ComicDbContext _context;

        public CategoryService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from c in _context.Categories join dc in _context.DetailCategories on c.Id equals dc.CategoryId select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory }).ToListAsync();

        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            var query = from c in _context.Categories join dc in _context.DetailCategories on c.Id equals dc.CategoryId where c.Id == id select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory }).FirstOrDefaultAsync();

        }

        public async Task<CategoryViewModel> GetBySeoAlias(string seoAlias)
        {
            var query = from c in _context.Categories join dc in _context.DetailCategories on c.Id equals dc.CategoryId where dc.SeoAlias == seoAlias select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory }).FirstOrDefaultAsync();

        }

        public async Task<List<CategoryViewModel>> GetBySize(int number)
        {
            var query = from c in _context.Categories join dc in _context.DetailCategories on c.Id equals dc.CategoryId orderby c.DateCreated descending select new  { c, dc };

            if(number > 0)
            {
                var categories = await query.Take(number).Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory }).ToListAsync();
                return categories;
            }
            return null;
        }

        public async Task<List<CategoryViewModel>> GetCategoryShowHome()
        {
            var query = from c in _context.Categories where c.IsActive == true join dc in _context.DetailCategories on c.Id equals dc.CategoryId where c.IsShowHome == true select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId, UrlImageCategory = x.c.UrlImageCategory }).ToListAsync();
        }
    }
}
