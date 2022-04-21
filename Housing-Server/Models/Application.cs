namespace Housing_Server.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string PropertyCategory { get; set; } = string.Empty;
        public string PropertyService { get; set; } = string.Empty;
        public int PropertyId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
