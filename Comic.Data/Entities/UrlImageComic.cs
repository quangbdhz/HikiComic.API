namespace Comic.Data.Entities
{
    public class UrlImageComic
    {
        public int Id { get; set; }

        public int ChapterComicId { get; set; }

        public string UrlImageChapterComic { get; set; }

        public bool IsActive { get; set; }


        public ChapterComic ChapterComic { get; set; }

    }
}
