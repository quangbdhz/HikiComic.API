using Comic.Data.EF;
using Comic.ViewModels.Authors;
using Comic.ViewModels.Categories;
using Comic.ViewModels.DetailComics;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Comic.Application.DetailComics
{
    public class DetailComicService : IDetailComicService
    {
        private readonly ComicDbContext _context;

        public DetailComicService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<DetailComicViewModel> GetById(int id)
        {
            var comic = await _context.ComicStrips.FirstOrDefaultAsync(x => x.Id == id && x.IsActive == true);
            var detailComic = await _context.DetailComics.FirstOrDefaultAsync(x => x.Id == id);

            if (comic == null || detailComic == null)
                return null;

            var queryCategory = from c in _context.Categories
                                join dc in _context.DetailCategories on c.Id equals dc.CategoryId
                                join cidc in _context.CategoryInDetailComics on c.Id equals cidc.CategoryId
                                where cidc.DetailComicId == comic.Id select new { c, dc };

            var categories = await queryCategory.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId }).ToListAsync();


            var queryAuthors = from a in _context.Authors
                          join aidc in _context.AuthorInDetailComics on a.Id equals aidc.AuthorId
                          where a.Id == detailComic.Id && a.IsActive == true
                          select a;

            var authors =  await queryAuthors.Select(x => new AuthorViewModel() { Id = x.Id, NameAuthor = x.NameAuthor, DifferentName = x.DifferentName, SeoAlias = x.SeoAlias, DateCreated = x.DateCreated }).ToListAsync();

            var detailComicViewModel = new DetailComicViewModel()
            {
                Id = comic.Id,
                NameComic = comic.NameComic,
                DifferentNameComic = comic.DifferentNameComic,
                ViewCount = comic.ViewCount,
                UrlCoverImageComic = comic.UrlCoverImageComic,
                DateCreated = comic.DateCreated,
                IdNewChapter = comic.IdNewChapter,
                Rating = detailComic.Rating,
                Description = detailComic.Description,
                SeoDescription = detailComic.SeoDescription,
                SeoTitle = detailComic.SeoTitle,
                SeoAlias = detailComic.SeoAlias,
                Categories = categories, 
                Authors = authors
            };

            return detailComicViewModel;
        }

        public async Task<DetailComicViewModel> GetBySeoAlias(string seoAlias)
        {
            seoAlias = WebUtility.UrlDecode(seoAlias);

            var detailComic = await _context.DetailComics.FirstOrDefaultAsync(x => x.SeoAlias == seoAlias);

            if(detailComic == null)
            {
                return null;
            }

            var comic = await _context.ComicStrips.FirstOrDefaultAsync(x => x.Id == detailComic.Id && x.IsActive == true);

            if (comic == null || detailComic == null)
                return null;

            var queryCategory = from c in _context.Categories
                                join dc in _context.DetailCategories on c.Id equals dc.CategoryId
                                join cidc in _context.CategoryInDetailComics on c.Id equals cidc.CategoryId
                                where cidc.DetailComicId == comic.Id
                                select new { c, dc };

            var categories = await queryCategory.Select(x => new CategoryViewModel() { Id = x.c.Id, Name = x.dc.NameCategory, SeoAlias = x.dc.SeoAlias, ParentId = x.c.ParentId }).ToListAsync();


            var queryAuthors = from a in _context.Authors
                               join aidc in _context.AuthorInDetailComics on a.Id equals aidc.AuthorId
                               where a.Id == detailComic.Id && a.IsActive == true
                               select a;

            var authors = await queryAuthors.Select(x => new AuthorViewModel() { Id = x.Id, NameAuthor = x.NameAuthor, DifferentName = x.DifferentName, SeoAlias = x.SeoAlias, DateCreated = x.DateCreated }).ToListAsync();

            string status = "";

            if(detailComic.StatusId == 1)
            {
                status = "Đang Tiến Hành";
            }
            else
            {
                status = "Hoàn thành";
            }

            var detailComicViewModel = new DetailComicViewModel()
            {
                Id = comic.Id,
                NameComic = comic.NameComic,
                DifferentNameComic = comic.DifferentNameComic,
                ViewCount = comic.ViewCount,
                UrlCoverImageComic = comic.UrlCoverImageComic,
                DateCreated = comic.DateCreated,
                IdNewChapter = comic.IdNewChapter,
                Rating = detailComic.Rating,
                Description = detailComic.Description,
                SeoDescription = detailComic.SeoDescription,
                SeoTitle = detailComic.SeoTitle,
                SeoAlias = detailComic.SeoAlias,
                Categories = categories,
                Authors = authors,
                Status = status
            };

            return detailComicViewModel;
        }
    }
}
