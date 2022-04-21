using Housing_Server.Models;

namespace Housing_Server
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<PropertyBuy> PropertyBuys { get; set; }
        public DbSet<PropertyRent> PropertyRents { get; set; }
        public DbSet<PropertyPG> PropertyPGs { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}
