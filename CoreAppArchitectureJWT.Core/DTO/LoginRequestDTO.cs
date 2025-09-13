using System.ComponentModel.DataAnnotations;

namespace CoreAppArchitectureJWT.Core.DTO
{
    public class LoginRequestDTO
    {
        [Required(ErrorMessage = "Please provide your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please provide your password")]
        public string Password { get; set; }
    }
}
