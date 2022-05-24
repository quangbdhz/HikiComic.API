namespace Comic.ViewModels.ComicStrips.ComicStripRequest
{
    public class ComicStripUpdateRequest
    {
        public int ComicId { get; set; }

        public string? DifferentNameComic { get; set; }

        public string UrlCoverImageComic { get; set; }

        public string Description { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoTitle { get; set; }
    }
}
