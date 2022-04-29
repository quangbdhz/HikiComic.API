namespace Comic.Data.Entities
{
    public class DetailCategory
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string NameCategory { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoTitle { get; set; }

        public string SeoAlias { get; set; }


        public Category Category { get; set; }
    }
}
