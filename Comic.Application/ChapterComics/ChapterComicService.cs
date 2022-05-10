using Comic.Data.EF;
using Comic.ViewModels.ChapterComics;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Comic.Application.ChapterComics
{
    public class ChapterComicService : IChapterComicService
    {
        private readonly ComicDbContext _context;

        public ChapterComicService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<List<ChapterComicViewModel>> GetByComicId(int idComic)
        {
            var queryChapterComic = from c in _context.ChapterComics where c.ComicId == idComic
                                    select new { c };

            var chapterComics = await queryChapterComic.Select(x => new ChapterComicViewModel() { Id = x.c.Id, ComicId = x.c.ComicId, DateCreated = x.c.DateCreated, NameChapter = x.c.NameChapter, ViewCount = x.c.ViewCount, SeoAlias = x.c.SeoAlias }).ToListAsync();

            return chapterComics;
        }

        public async Task<List<ChapterComicViewModel>> GetByComicSeoAlias(string seoAliasComic)
        {
            var getComic = await _context.DetailComics.SingleOrDefaultAsync(x => x.SeoAlias == seoAliasComic);

            if(getComic != null)
            {
                var queryChapterComic = from c in _context.ChapterComics
                                        where c.ComicId == getComic.ComicId
                                        select new { c };

                var chapterComics = await queryChapterComic.Select(x => new ChapterComicViewModel() { Id = x.c.Id, ComicId = x.c.ComicId, DateCreated = x.c.DateCreated, NameChapter = x.c.NameChapter, ViewCount = x.c.ViewCount, SeoAlias = x.c.SeoAlias }).ToListAsync();

                return chapterComics;
            }

            return null;
        }

    }
}
