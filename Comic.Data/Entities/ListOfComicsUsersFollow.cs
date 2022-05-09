namespace Comic.Data.Entities
{
    public class ListOfComicsUsersFollow
    {
        public int Id { get; set; }

        public Guid AppUserId { get; set; }

        public int ComicId { get; set; }

        public DateTime DateFollow { get; set; }


        public AppUser AppUser { get; set; }

        public ComicStrip ComicStrip { get; set; }
    }
}
