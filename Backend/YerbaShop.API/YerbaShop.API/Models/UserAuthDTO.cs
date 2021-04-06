namespace YerbaShop.API.Models
{
    public class UserAuthDTO
    {
        public string email { get; set; }
        public string password { get; set; }

        public UserAuthDTO( string email, string password)
        {
            this.password = password;
            this.email = email;
        }
    }
}
