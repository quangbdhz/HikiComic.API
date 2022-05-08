namespace Comic.Data.Entities
{
    public class HistoryReadComicOfUser
    {
        public int Id { get; set; }

        public Guid AppUserId { get; set; }

        public int ComicId { get; set; }

        public int ChapterId { get; set; }

        public DateTime DateRead { get; set; }


        public AppUser AppUser { get; set; }

        public ComicStrip ComicStrip { get; set; }

        public ChapterComic ChapterComic { get; set; }
    }
}
