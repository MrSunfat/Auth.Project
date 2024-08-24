using Microsoft.AspNetCore.Identity;

namespace Auth.API.Models.AppUser
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
