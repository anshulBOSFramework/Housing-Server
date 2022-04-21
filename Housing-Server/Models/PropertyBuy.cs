namespace Housing_Server.Models
{
    public class PropertyBuy
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PropertyCategory { get; set; } = string.Empty;
        public string PropertyService { get; set; } = string.Empty;
        public string PropertyType { get; set; } = string.Empty;
        public string ContructionStatus { get; set; } = string.Empty;
        public string PropertyAge { get; set; } = string.Empty;
        public string PropertyBhk { get; set; } = string.Empty;
        public string PropertyBathroom { get; set; } = string.Empty;
        public string PropertyBalcony { get; set; } = string.Empty;
        public string PropertyFurniture { get; set; } = string.Empty;
        public string PropertyCoveredParking { get; set; } = string.Empty;
        public string PropertyOpenParking { get; set; } = string.Empty;
        public string PropertyCost { get; set; } = string.Empty;
        public string PropertyMaintenanceCost { get; set; } = string.Empty;
        public string PropertyArea { get; set; } = string.Empty;
        public string PropertyCarpetArea { get; set; } = string.Empty;
        public string PropertyPossessionDate { get; set; } = string.Empty;
        public Address? Address { get; set; }
    }
}
