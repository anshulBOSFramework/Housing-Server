using System.ComponentModel.DataAnnotations;

namespace Housing_Server.DTOs
{
    public class User_LoginDto
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
