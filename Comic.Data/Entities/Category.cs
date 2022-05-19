namespace Comic.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        
        public int? ParentId { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsActive { get; set; }

        public bool IsShowHome { get; set; }

        public string UrlImageCategory { get; set; }


        public List<CategoryInDetailComic> CategoryInDetailComics { get; set; }


        public List<DetailCategory> DetailCategories { get; set; }
    }
}
