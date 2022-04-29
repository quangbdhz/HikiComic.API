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

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId}).ToListAsync();

        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            var query = from c in _context.Categories join dc in _context.DetailCategories on c.Id equals dc.CategoryId where c.Id == id select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId }).FirstOrDefaultAsync();

        }

        public async Task<CategoryViewModel> GetBySeoAlias(string seoAlias)
        {
            var query = from c in _context.Categories join dc in _context.DetailCategories on c.Id equals dc.CategoryId where dc.SeoAlias == seoAlias select new { c, dc };

            return await query.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId }).FirstOrDefaultAsync();

        }
    }
}
