namespace Comic.Data.Entities
{
    public class AuthorInDetailComic
    {
        public int AuthorId { get; set; }

        public int DetailComicId { get; set; }

        public Author Author { get; set; }

        public DetailComic DetailComic { get; set; }

    }
}
