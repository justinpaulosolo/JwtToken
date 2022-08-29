using System.ComponentModel.DataAnnotations;

namespace JwtToken.Models
{
    public class UserRegistrationRequest
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string PasswordConfirm { get; set; } = string.Empty;
    }
}
