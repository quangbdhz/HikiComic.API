using Microsoft.AspNetCore.Identity;

namespace Comic.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string? Description { get; set; }
    }
}
