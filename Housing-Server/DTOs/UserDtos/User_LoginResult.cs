using Housing_Server.Models;

namespace Housing_Server.DTOs
{
    public class User_LoginResult
    {
        public User User { get; set; }
        public string Token { get; set; }
        public User_LoginResult()
        {
            Token = string.Empty;
            User = new User();
        }
    }
}
