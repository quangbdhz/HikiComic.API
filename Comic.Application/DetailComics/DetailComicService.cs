using Comic.Data.EF;
using Comic.Data.Entities;
using Comic.Utilities.Constants;
using Comic.ViewModels.Authors;
using Comic.ViewModels.Categories;
using Comic.ViewModels.Common;
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
            return await GetDetaiComicViewModel(1, null, id, null);
        }

        public async Task<DetailComicViewModel> GetById(Guid userId, int id)
        {
            return await GetDetaiComicViewModel(1, null, id, userId);
        }

        public async Task<DetailComicViewModel> GetBySeoAlias(string seoAlias)
        {
            seoAlias = WebUtility.UrlDecode(seoAlias);

            return await GetDetaiComicViewModel(2, seoAlias, null, null);
        }

        public async Task<DetailComicViewModel> GetBySeoAlias(Guid userId, string seoAlias)
        {
            seoAlias = WebUtility.UrlDecode(seoAlias);

            return await GetDetaiComicViewModel(2, seoAlias, null, userId);
        }

        public async Task<DetailComicViewModel> GetDetaiComicViewModel(int option, string? seoAlias, int? idComic, Guid? userId)
        {
            var detailComic = await GetDetaiComic(option, seoAlias, idComic);

            if (detailComic == null)
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

            if (detailComic.StatusId == 1)
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

            if(userId != null)
            {
                var userFollowComic = await _context.ListOfComicsUsersFollows.SingleOrDefaultAsync(x => x.AppUserId == userId && x.ComicId == detailComic.ComicId);
                if(userFollowComic != null)
                {
                    detailComicViewModel.IsFollow = true;
                }

            }

            return detailComicViewModel;
        }

        public async Task<DetailComic> GetDetaiComic(int option, string? seoAlias, int? idComic)
        {
            if(option == 1)
                return await _context.DetailComics.FirstOrDefaultAsync(x => x.ComicId == idComic);
            else
                return await _context.DetailComics.FirstOrDefaultAsync(x => x.SeoAlias == seoAlias);
        }

        public async Task<ApiResult<bool>> UpdateUserFollowComic(Guid userId, int comicId)
        {
            var user = await _context.Users.FindAsync(userId);
            if(user == null)
                return new ApiErrorResult<bool>(MessageConstants.UserIsNotAvailable);

            var userFollowComic = await _context.ListOfComicsUsersFollows.SingleOrDefaultAsync(x => x.ComicId == comicId && x.AppUserId == userId);
            if(userFollowComic == null)
            {
                ListOfComicsUsersFollow listOfComicsUsersFollow = new ListOfComicsUsersFollow() { AppUserId = userId, ComicId = comicId, DateFollow = DateTime.Now };
                await _context.ListOfComicsUsersFollows.AddAsync(listOfComicsUsersFollow);
                await _context.SaveChangesAsync();

                return new ApiSuccessResult<bool>("Has been added to the following story list");
            }
            else
            {
                _context.ListOfComicsUsersFollows.Remove(userFollowComic);
                await _context.SaveChangesAsync();

                return new ApiSuccessResult<bool>("The story has been removed from the list of watching stories");
            }


        }
    }
}
