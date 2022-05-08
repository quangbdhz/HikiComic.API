using Comic.ViewModels.Common;

namespace Comic.ViewModels.ComicStrips.ComicStripRequest
{
    public class ComicStripPagingRequest : PagingRequestBase
    {
        public string? Keyword { get; set; }

        public int? CategoryId { get; set; }
    }
}
