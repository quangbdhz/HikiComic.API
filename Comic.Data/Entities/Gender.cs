namespace Comic.Data.Entities
{
    public class Gender
    {
        public int Id { get; set; }

        public string? NameGender { get; set; }

        public List<AppUser>? AppUsers { get; set; }
    }
}
