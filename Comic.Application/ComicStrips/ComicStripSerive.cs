using Comic.Data.EF;
using Comic.Data.Entities;
using Comic.ViewModels.Authors;
using Comic.ViewModels.ComicStrips;
using Comic.ViewModels.ComicStrips.ComicStripRequest;
using Comic.ViewModels.Common;
using Microsoft.EntityFrameworkCore;

namespace Comic.Application.ComicStrips
{
    public class ComicStripSerive : IComicStripService
    {
        private readonly ComicDbContext _context;

        public ComicStripSerive(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddViewcount(int comicStripId)
        {
            var comicStrip = await _context.ComicStrips.FindAsync(comicStripId);
            if (comicStrip != null)
            {
                comicStrip.ViewCount += 1;
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<ApiResult<bool>> AddRating(int comicStripId, double rating)
        {
            var detailComic = await _context.DetailComics.SingleOrDefaultAsync(x => x.ComicId == comicStripId);

            if (detailComic == null)
            {
                return new ApiErrorResult<bool>("ComicStrip Is Null");
            }

            detailComic.Rating = ((detailComic.CountRating * detailComic.Rating) + rating) / (detailComic.CountRating + 1);
            detailComic.CountRating += 1;

            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>();
        }

        public async Task<int> Create(ComicStripCreateRequest request)
        {
            int countAuthor = request.Authors.Count();
            if (countAuthor == 0)
                return 0;

            int countCategory = request.Categories.Count();
            if (countCategory == 0)
                return 0;

            var comicStrip = new ComicStrip()
            {
                NameComic = request.NameComic,
                DifferentNameComic = request.DifferentNameComic,
                ViewCount = 0,
                UrlCoverImageComic = request.UrlCoverImageComic,
                DateCreated = DateTime.Now,
                IsActive = true,
                IdNewChapter = null
            };
            _context.ComicStrips.Add(comicStrip);
            await _context.SaveChangesAsync();

            var detailComic = new DetailComic()
            {
                ComicId = comicStrip.Id,
                StatusId = 1,
                CountFollow = 0,
                CountRating = 0,
                Rating = 0,
                Description = request.Description,
                SeoDescription = request.SeoDescription,
                SeoTitle = request.SeoTitle,
                SeoAlias = request.SeoAlias,
            };
            _context.DetailComics.Add(detailComic);
            await _context.SaveChangesAsync();

            if (countAuthor > 0)
            {
                var authorInDetailComic = new AuthorInDetailComic();
                foreach (var item in request.Authors)
                {
                    authorInDetailComic.AuthorId = item;
                    authorInDetailComic.DetailComicId = detailComic.Id;

                    _context.AuthorInDetailComics.Add(authorInDetailComic);
                    await _context.SaveChangesAsync();

                }
            }

            if (countCategory > 0)
            {
                var categoryInDetailComic = new CategoryInDetailComic();
                foreach (var item in request.Categories)
                {
                    categoryInDetailComic.CategoryId = item;
                    categoryInDetailComic.DetailComicId = detailComic.Id;

                    _context.CategoryInDetailComics.Add(categoryInDetailComic);
                    await _context.SaveChangesAsync();

                }
            }

            return comicStrip.Id;
        }

        public async Task<ApiResult<bool>> Delete(int comicStripId)
        {
            var comicStrip = await _context.ComicStrips.SingleOrDefaultAsync(x => x.Id == comicStripId);

            if (comicStrip == null)
                return new ApiErrorResult<bool>("ComicStrip Is Null");

            comicStrip.IsActive = !comicStrip.IsActive;
            await _context.SaveChangesAsync();

            if (!comicStrip.IsActive)
                return new ApiSuccessResult<bool>("Delete Comic Is Success");

            return new ApiSuccessResult<bool>("Activated Comic");
        }

        public async Task<PagedResult<ComicStripViewModel>> GetAllPaging(ComicStripPagingRequest request)
        {
            return await GetComicStripViewModel(1, request);
        }

        public async Task<ApiResult<bool>> Update(ComicStripUpdateRequest request)
        {
            var comic = await _context.ComicStrips.SingleOrDefaultAsync(x => x.Id == request.ComicId);
            if (comic == null)
                return new ApiErrorResult<bool>("Comic Is Not Available");

            comic.DifferentNameComic = request.DifferentNameComic;
            comic.UrlCoverImageComic = request.UrlCoverImageComic;
            await _context.SaveChangesAsync();

            var detailComic = await _context.DetailComics.SingleOrDefaultAsync(x => x.ComicId == request.ComicId);
            if (detailComic != null)
            {
                detailComic.SeoTitle = request.SeoTitle;
                detailComic.SeoDescription = request.SeoDescription;
                detailComic.Description = request.Description;

                await _context.SaveChangesAsync();

                return new ApiSuccessResult<bool>("Update Comic Is Success");
            }
            return new ApiErrorResult<bool>("DetailComic Is Not Available");
        }

        public async Task<List<ComicStripViewModel>> GetNewComicPaging(PagingRequestBase request)
        {

            var query = from c in _context.ComicStrips
                        join dc in _context.DetailComics on c.Id equals dc.ComicId
                        where c.IsActive == true orderby c.DateCreated descending
                        select new { c, dc };

            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new ComicStripViewModel()
            {
                Id = x.c.Id,
                NameComic = x.c.NameComic,
                DateCreated = x.c.DateCreated,
                DifferentNameComic = x.c.DifferentNameComic,
                ViewCount = x.c.ViewCount,
                UrlCoverImageComic = x.c.UrlCoverImageComic,
                IdNewChapter = x.c.IdNewChapter,
                SeoAlias = x.dc.SeoAlias,
                Rating = x.dc.Rating
            }).ToListAsync();

            return data;
        }

        public async Task<List<ComicStripViewModel>> GetHotComicPaging()
        {
            var query = from c in _context.ComicStrips
                        join dc in _context.DetailComics on c.Id equals dc.ComicId
                        where c.IsActive == true
                        orderby c.ViewCount descending
                        select new { c, dc };

            int totalRow = await query.CountAsync();

            var data = await query.Select(x => new ComicStripViewModel()
            {
                Id = x.c.Id,
                NameComic = x.c.NameComic,
                DateCreated = x.c.DateCreated,
                DifferentNameComic = x.c.DifferentNameComic,
                ViewCount = x.c.ViewCount,
                UrlCoverImageComic = x.c.UrlCoverImageComic,
                IdNewChapter = x.c.IdNewChapter,
                SeoAlias = x.dc.SeoAlias,
                Rating = x.dc.Rating
            }).ToListAsync();

            List<ComicStripViewModel> newData = new List<ComicStripViewModel>();

            int count = 0;
            foreach (var item in data)
            {
                newData.Add(item);
                count++;

                if (count > 5) break;
            }

            return newData;
        }

        public async Task<PagedResult<ComicStripViewModel>> GetAllPagingManager(ComicStripPagingRequest request)
        {
            return await GetComicStripViewModel(0, request);
        }

        public async Task<PagedResult<ComicStripViewModel>> GetComicStripViewModel(int option, ComicStripPagingRequest request)
        {
            if (request.CategoryId != null && request.CategoryId != 0)
            {
                var query = from c in _context.ComicStrips
                            join dc in _context.DetailComics on c.Id equals dc.ComicId
                            join cidc in _context.CategoryInDetailComics on dc.Id equals cidc.DetailComicId
                            select new { c, dc, cidc };

                if(option == 1)
                {
                    query = query.Where(x => x.c.IsActive == true);
                }

                query = query.Where(p => p.cidc.CategoryId == request.CategoryId);

                if (!string.IsNullOrEmpty(request.Keyword))
                    query = query.Where(x => x.c.NameComic.Contains(request.Keyword));

                int totalRow = await query.CountAsync();

                var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                  .Select(x => new ComicStripViewModel()
                  {
                      Id = x.c.Id,
                      NameComic = x.c.NameComic,
                      DateCreated = x.c.DateCreated,
                      DifferentNameComic = x.c.DifferentNameComic,
                      ViewCount = x.c.ViewCount,
                      UrlCoverImageComic = x.c.UrlCoverImageComic,
                      IdNewChapter = x.c.IdNewChapter,
                      SeoAlias = x.dc.SeoAlias,
                      Rating = x.dc.Rating,
                      IsActive = x.c.IsActive
                  }).ToListAsync();

                var pagedResult = new PagedResult<ComicStripViewModel>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
            }
            else
            {
                var query = from c in _context.ComicStrips
                            join dc in _context.DetailComics on c.Id equals dc.ComicId
                            select new { c, dc };

                if (option == 1)
                {
                    query = query.Where(x => x.c.IsActive == true);
                }

                if (!string.IsNullOrEmpty(request.Keyword))
                    query = query.Where(x => x.c.NameComic.Contains(request.Keyword));

                int totalRow = await query.CountAsync();

                var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                  .Select(x => new ComicStripViewModel()
                  {
                      Id = x.c.Id,
                      NameComic = x.c.NameComic,
                      DateCreated = x.c.DateCreated,
                      DifferentNameComic = x.c.DifferentNameComic,
                      ViewCount = x.c.ViewCount,
                      UrlCoverImageComic = x.c.UrlCoverImageComic,
                      IdNewChapter = x.c.IdNewChapter,
                      SeoAlias = x.dc.SeoAlias,
                      Rating = x.dc.Rating,
                      IsActive = x.c.IsActive
                  }).ToListAsync();

                var pagedResult = new PagedResult<ComicStripViewModel>()
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
}
