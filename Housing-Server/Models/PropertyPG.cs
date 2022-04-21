namespace Housing_Server.Models
{
    public class PropertyPG
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PropertyCategory { get; set; } = string.Empty;
        public string PropertyService { get; set; } = string.Empty;
        public string? PropertyName { get; set; } = string.Empty;
        public string PropertyBeds { get; set; } = string.Empty;
        public string PropertyPGType { get; set; } = string.Empty;
        public string PropertySuited { get; set; } = string.Empty;
        public bool PropertyMeals { get; set; } = false;
        public string PropertyNotice { get; set; } = string.Empty;
        public string PropertyLock { get; set; } = string.Empty;
        public string PropertyCommonArea { get; set; } = string.Empty;
        public string PropertyManaged { get; set; } = string.Empty;
        public bool? PropertyIsManaged { get; set; } = false;
        public bool IsNonVeg { get; set; } = false;
        public bool IsOppositeSex { get; set; } = false;
        public bool IsAnyTimeAllowed { get; set; } = false;
        public bool IsVisitorAllowed { get; set; } = false;
        public bool IsGuardianAllowed { get; set; } = false;
        public bool IsDrinkingAllowed { get; set; } = false;
        public bool IsSmokingAllowed { get; set; } = false;
        public Address? Address { get; set; }
    }
}
