using System.ComponentModel.DataAnnotations;

namespace Housing_Server.DTOs.ApplicationDtos
{
    public class Application_BuyDto
    {
        [Required]
        public int PropertyId { get; set; }
        [Required]
        public string PropertyCategory { get; set; } = string.Empty;
        [Required]
        public string PropertyService { get; set; } = string.Empty;
        [Required]
        public string Name{ get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
    }
}
