using Housing_Server.Models;

namespace Housing_Server.DTOs.PropertyDtos
{
    public class Property_ResultDto
    {
        public List<PropertyBuy> BuyList { get; set; } = new List<PropertyBuy>();
        public List<PropertyRent> RentList { get; set; } = new List<PropertyRent>();
        public List<PropertyPG> PGList { get; set; } = new List<PropertyPG>();
    }
}
