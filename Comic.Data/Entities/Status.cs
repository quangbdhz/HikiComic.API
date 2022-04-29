namespace Comic.Data.Entities
{
    public class Status
    {
        public int Id { get; set; }

        public string NameStatus { get; set; }


        public List<DetailComic> DetailComics { get; set; }
    }
}
