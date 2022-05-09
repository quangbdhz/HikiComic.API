using Comic.Data.EF;
using Comic.ViewModels.ComicStrips;
using Comic.ViewModels.Common;
using Microsoft.EntityFrameworkCore;

namespace Comic.Application.ListOfComicsUsersFollows
{
    public class ListOfComicsUsersFollowService : IListOfComicsUsersFollowService
    {
        private readonly ComicDbContext _context;

        public ListOfComicsUsersFollowService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<ComicStripViewModel>> GetAllPaging(PagingRequestBase request, Guid userId)
        {
            var query = from l in _context.ListOfComicsUsersFollows where l.AppUserId == userId
                        join c in _context.ComicStrips on l.ComicId equals c.Id
                        join dc in _context.DetailComics on c.Id equals dc.Id
                        where c.IsActive == true
                        select new { c, dc };

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
}
