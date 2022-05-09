namespace Comic.ViewModels.Categories
{
    public class CategoryViewModel
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? SeoAlias { get; set; }

        public int? ParentId { get; set; }

        public string UrlImageCategory { get; set; }
    }
}
