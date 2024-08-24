using System.ComponentModel.DataAnnotations;

namespace Auth.API.Dto
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string FullName { get; set; }

        public string Password { get; set; } = string.Empty;

        public List<string>? Roles { get; set; }
    }
}
