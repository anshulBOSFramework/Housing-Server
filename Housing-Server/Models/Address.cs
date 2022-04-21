namespace Housing_Server.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string CityName { get; set; } = string.Empty;
        public string ProjectDetails { get; set; } = string.Empty;
        public string Locality { get; set; } = string.Empty;
        public string? FlatNo { get; set; } = string.Empty;
        public string FloorNo { get; set; } = string.Empty;
        public string TotalFloors { get; set; } = string.Empty;
    }
}
