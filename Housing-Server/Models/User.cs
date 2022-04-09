namespace Housing_Server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string AccountCategory { get; set; } = string.Empty;

        public User ()
        {
            PasswordHash = new byte[32];
            PasswordSalt = new byte[32];
        }
    } 
}
