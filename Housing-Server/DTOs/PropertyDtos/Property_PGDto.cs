using System.ComponentModel.DataAnnotations;
using Housing_Server.Models;

namespace Housing_Server.DTOs.PropertyDtos
{
    public class Property_PGDto
    {
        [Required]
        public PropertyPG PropertyPG { get; set; }
        [Required]
        public Address Address { get; set; }
        public Property_PGDto()
        {
            PropertyPG = new PropertyPG();
            Address = new Address();
        }
    }
}
