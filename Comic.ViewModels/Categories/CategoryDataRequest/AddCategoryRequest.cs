namespace Comic.ViewModels.Categories.CategoryDataRequest
{
    public class AddCategoryRequest
    {
        public int? ParentId { get; set; }

        public string NameCategory { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoTitle { get; set; }

        public string SeoAlias { get; set; }

        public bool IsShowHome { get; set; }

        public string UrlImageCategory { get; set; }
    }
}
