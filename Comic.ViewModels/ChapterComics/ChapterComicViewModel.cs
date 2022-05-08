namespace Comic.ViewModels.ChapterComics
{
    public class ChapterComicViewModel
    {
        public int Id { get; set; }

        public int ComicId { get; set; }

        public string NameChapter { get; set; }

        public DateTime DateCreated { get; set; }

        public int ViewCount { get; set; }

        public string SeoAlias { get; set; }
    }
}
