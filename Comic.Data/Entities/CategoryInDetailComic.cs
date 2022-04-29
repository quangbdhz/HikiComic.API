namespace Comic.Data.Entities
{
    public class CategoryInDetailComic
    {
        public int CategoryId { get; set; }

        public int DetailComicId { get; set; }

        public Category Category { get; set; }

        public DetailComic DetailComic { get; set; }
    }
}
