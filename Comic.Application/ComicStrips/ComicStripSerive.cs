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
            if(comicStrip != null)
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

            if(detailComic == null)
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

            if(countAuthor > 0)
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

            if(countCategory > 0)
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

            if(comicStrip == null)
                return new ApiErrorResult<bool>("ComicStrip Is Null");

            comicStrip.IsActive = false;
            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>();
        }

        public async Task<PagedResult<ComicStripViewModel>> GetAllPaging(ComicStripPagingRequest request)
        {
            if (request.CategoryId != null && request.CategoryId != 0)
            {
                var query = from c in _context.ComicStrips
                            join dc in _context.DetailComics on c.Id equals dc.ComicId
                            join cidc in _context.CategoryInDetailComics on dc.Id equals cidc.DetailComicId
                            where c.IsActive == true
                            select new { c, dc, cidc };

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
                      Rating = x.dc.Rating
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
                            where c.IsActive == true
                            select new { c, dc };

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
                      Rating = x.dc.Rating
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

        public Task<int> Update(ComicStripUpdateRequest request)
        {
            throw new NotImplementedException();
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
            foreach(var item in data)
            {
                newData.Add(item);
                count++;

                if (count > 2) break;
            }

            return newData;
        }
    }
}
