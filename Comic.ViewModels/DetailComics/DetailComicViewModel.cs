using Comic.ViewModels.Authors;
using Comic.ViewModels.Categories;

namespace Comic.ViewModels.DetailComics
{
    public class DetailComicViewModel
    {
        public int Id { get; set; }

        public string NameComic { get; set; }

        public string? DifferentNameComic { get; set; }

        public int ViewCount { get; set; }

        public string UrlCoverImageComic { get; set; }

        public DateTime DateCreated { get; set; }

        public int? IdNewChapter { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoTitle { get; set; }

        public string SeoAlias { get; set; }


        public List<AuthorViewModel> Authors { get; set; } = new List<AuthorViewModel>();

        public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
    }
}
