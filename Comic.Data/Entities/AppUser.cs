using Microsoft.AspNetCore.Identity;

namespace Comic.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string? UrlImageUser { get; set; }

        public string? MoreInfo { get; set; }

        public bool IsActive { get; set; }

        public int GenderId { get; set; }

        public Gender? Gender { get; set; }

        public string RefreshToken { get; set; }

        public DateTime? TokenCreated { get; set; }

        public DateTime? TokenExpires { get; set; }

        public List<HistoryReadComicOfUser> HistoryReadComicOfUsers { get; set; }

        public List<ListOfComicsUsersFollow> ListOfComicsUsersFollows { get; set; }
    }
}
