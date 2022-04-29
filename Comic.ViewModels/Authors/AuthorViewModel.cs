namespace Comic.ViewModels.Authors
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        public string NameAuthor { get; set; }

        public string? DifferentName { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsActive { get; set; }

        public string SeoAlias { get; set; }
    }
}
