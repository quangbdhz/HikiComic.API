using Comic.Data.EF;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Comic.Application.UrlChapterImageComics
{
    public class UrlChapterImageComicService : IUrlChapterImageComicService
    {
        private readonly ComicDbContext _context;

        public UrlChapterImageComicService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<List<string>> GetByChapterComicId(int id)
        {
            var queryUrlChapterImageComic = from c in _context.UrlImageComics
                                            where c.ChapterComicId == id
                                            select new { c };

            var listUrlChapterImageComics = await queryUrlChapterImageComic.Select(x => x.c.UrlImageChapterComic).ToListAsync();

            List<string> urlDecode = CutUrlToListUrl(listUrlChapterImageComics);

            return urlDecode;
        }

        public async Task<List<string>> GetByChapterComicSeoAlias(string seoAlias)
        {
            seoAlias = WebUtility.UrlDecode(seoAlias);
            var getChapterComic = await _context.ChapterComics.SingleOrDefaultAsync(x => x.SeoAlias == seoAlias);

            if (getChapterComic != null)
            {
                var queryUrlChapterImageComic = from c in _context.UrlImageComics
                                                where c.ChapterComicId == getChapterComic.Id
                                                select new { c };

                var listUrlChapterImageComics = await queryUrlChapterImageComic.Select(x => x.c.UrlImageChapterComic).ToListAsync();

                List<string> urlDecode = CutUrlToListUrl(listUrlChapterImageComics);

                return urlDecode;
            }
            return null;
        }

        public List<string> CutUrlToListUrl(List<string> lvUrlEncode)
        {
            List<string> lvUrlDecode = new List<string>();

            foreach (string item in lvUrlEncode)
            {
                int lenghtUrl = item.Length;
                string url = item;
                string subString = "";

                for (int i = 1; i < lenghtUrl; i++)
                {
                    if (url[i] == '|' && i != 0)
                    {
                        lvUrlDecode.Add(subString);
                        subString = "";
                    }
                    else
                    {
                        subString += url[i];
                    }
                }
            }
            return lvUrlDecode;
        }

    }
}
