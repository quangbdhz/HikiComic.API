namespace Comic.Data.Entities
{
    public class DetailComic
    {
        public int Id { get; set; }

        public int ComicId { get; set; }

        public int StatusId { get; set; }

        public int CountFollow { get; set; }

        public int CountRating { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoTitle { get; set; }

        public string SeoAlias { get; set; }


        public ComicStrip ComicStrip { get; set; }

        public Status Status { get; set; }

        public List<AuthorInDetailComic> AuthorInDetailComics { get; set; }

        public List<CategoryInDetailComic> CategoryInDetailComics { get; set; }
    }
}
