using System.ComponentModel.DataAnnotations;

namespace Drivers.Api.Models.DTOs
{
    public class UserLoginRequestDto
    {
        [Required]
        public string Email { get; set; } = String.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }

}