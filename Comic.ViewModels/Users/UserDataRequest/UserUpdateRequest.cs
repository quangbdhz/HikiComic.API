namespace Comic.ViewModels.Users.UserDataRequest
{
    public class UserUpdateRequest
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string PhoneNumber { get; set; }

        public int GenderId { get; set; }
    }
}
