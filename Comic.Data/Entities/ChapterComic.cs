namespace Comic.Data.Entities
{
    public class ChapterComic
    {
        public int Id { get; set; }

        public int ComicId { get; set; }

        public string NameChapter { get; set; }

        public DateTime DateCreated { get; set; }

        public int ViewCount { get; set; }

        public bool IsActive { get; set; }

        public string SeoAlias { get; set; }


        public List<ListOfComicsUsersFollow> ListOfComicsUsersFollows { get; set; }

        public List<UrlImageComic> UrlImageComics { get; set; }
    }
}
