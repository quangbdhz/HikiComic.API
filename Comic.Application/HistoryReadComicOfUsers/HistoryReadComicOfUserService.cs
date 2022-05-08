using Comic.Data.EF;
using Comic.Data.Entities;
using Comic.ViewModels.ComicStrips;
using Comic.ViewModels.Common;
using Comic.ViewModels.HistoryReadComicOfUsers.HistoryReadComicOfUserRequest;
using Microsoft.EntityFrameworkCore;

namespace Comic.Application.HistoryReadComicOfUsers
{
    public class HistoryReadComicOfUserService : IHistoryReadComicOfUserService
    {
        private readonly ComicDbContext _context;

        public HistoryReadComicOfUserService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<ComicStripViewModel>> GetAllPaging(PagingRequestBase request, Guid userId)
        {
            var query = from l in _context.HistoryReadComicOfUsers
                        where l.AppUserId == userId
                        join c in _context.ComicStrips on l.ComicId equals c.Id
                        join dc in _context.DetailComics on c.Id equals dc.Id
                        where c.IsActive == true orderby l.DateRead descending
                        select new { c, dc, l };

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
                 ReadChapterId = x.l.ChapterId
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

        public async Task<ApiResult<bool>> Update(HistoryReadComicOfUserUpdateRequest request)
        {
            var getComic = await _context.DetailComics.SingleOrDefaultAsync(x => x.SeoAlias == request.SeoAliasComic);

            if (getComic == null)
                return new ApiErrorResult<bool>("Comic Is Null");

            int idComic = getComic.ComicId;

            var checkComicInHistoryComic = await _context.HistoryReadComicOfUsers.SingleOrDefaultAsync(x => x.ComicId == getComic.ComicId && x.AppUserId == request.UserId);
            var getChapterComic = await _context.ChapterComics.SingleOrDefaultAsync(x => x.ComicId == getComic.ComicId && x.SeoAlias == request.SeoAliasChapterComic);

            if (checkComicInHistoryComic == null)
            {
                if(getChapterComic != null)
                {
                    HistoryReadComicOfUser historyReadComicOfUser = new HistoryReadComicOfUser() { AppUserId = request.UserId, ComicId = getComic.Id, ChapterId = getChapterComic.Id, DateRead = DateTime.Now };

                    await _context.HistoryReadComicOfUsers.AddAsync(historyReadComicOfUser);
                    await _context.SaveChangesAsync();

                    return new ApiSuccessResult<bool>();
                }

                return new ApiErrorResult<bool>("Comic Is Null And ChapterComic Is Null");
            }
            else
            {
                if (getChapterComic != null)
                {
                    checkComicInHistoryComic.ChapterId = getChapterComic.Id;
                    checkComicInHistoryComic.DateRead = DateTime.Now;
                    await _context.SaveChangesAsync();

                    return new ApiSuccessResult<bool>();
                }

                return new ApiErrorResult<bool>("ChapterComic Is Null");
            }
        }
    }
}
