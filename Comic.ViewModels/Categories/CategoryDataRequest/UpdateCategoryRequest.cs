namespace Comic.ViewModels.Categories.CategoryDataRequest
{
    public class UpdateCategoryRequest
    {
        public int CategoryId { get; set; }

        public int? ParentId { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoTitle { get; set; }

        public bool IsShowHome { get; set; }

        public string UrlImageCategory { get; set; }
    }
}
