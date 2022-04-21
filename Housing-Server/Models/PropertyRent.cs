namespace Housing_Server.Models
{
    public class PropertyRent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PropertyCategory { get; set; } = string.Empty;
        public string PropertyService { get; set; } = string.Empty;
        public string PropertyType { get; set; } = string.Empty;
        public int PropertyAge { get; set; }
        public int PropertyBhk { get; set; } 
        public int PropertyBathroom { get; set; }
        public int PropertyBalcony { get; set; } 
        public string PropertyFurniture { get; set; } = string.Empty;
        public int PropertyCoveredParking { get; set; } 
        public int PropertyOpenParking { get; set; }
        public int PropertyAvailable { get; set; } 
        public float PropertyMonthlyRent { get; set; }
        public float PropertyMaintenanceCost { get; set; } 
        public bool PropertyDeposit { get; set; }
        public float PropertyArea { get; set; } 
        public float PropertyCarpetArea { get; set; } 
        public string PropertyTenantType { get; set; }
        public Address? Address { get; set; }
    }
}
