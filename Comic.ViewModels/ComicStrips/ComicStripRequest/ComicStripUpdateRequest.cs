namespace Comic.ViewModels.ComicStrips.ComicStripRequest
{
    public class ComicStripUpdateRequest
    {
        public string NameComic { get; set; }

        public string? DifferentNameComic { get; set; }

        public string UrlCoverImageComic { get; set; }

        public string Description { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoTitle { get; set; }

        public string SeoAlias { get; set; }


        public List<int> Authors { get; set; } = new List<int>();

        public List<int> Categories { get; set; } = new List<int>();
    }
}
