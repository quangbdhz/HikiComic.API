namespace Comic.Data.Entities
{
    public class ComicStrip
    {
        public int Id { get; set; }

        public string NameComic { get; set; }

        public string? DifferentNameComic { get; set; }

        public int ViewCount { get; set; }

        public string UrlCoverImageComic { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsActive { get; set; }

        public int? IdNewChapter { get; set; }

        
        public List<DetailComic> DetailComics { get; set; }

        public List<HistoryReadComicOfUser>? HistoryReadComicOfUsers { get; set; }

        public List<ListOfComicsUsersFollow> ListOfComicsUsersFollows { get; set; }

    }
}
