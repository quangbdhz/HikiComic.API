using Comic.ViewModels.ChapterComics;

namespace Comic.ViewModels.ComicStrips
{
    public class ComicStripViewModel
    {
        public int Id { get; set; }

        public string NameComic { get; set; }

        public string? DifferentNameComic { get; set; }

        public int ViewCount { get; set; }

        public string UrlCoverImageComic { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsActive { get; set; }

        public int? IdNewChapter { get; set; }

        public string SeoAlias { get; set; }

        public double Rating { get; set; }

        public int? ReadChapterId { get; set; }

        public List<ChapterComicViewModel> ChapterComics { get; set; } = new List<ChapterComicViewModel>();
    }
}
