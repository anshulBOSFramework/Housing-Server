using System.ComponentModel.DataAnnotations;

namespace Housing_Server.DTOs
{
    public class User_RegisterDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string AccountCategory { get; set; } = string.Empty;
    }
}
