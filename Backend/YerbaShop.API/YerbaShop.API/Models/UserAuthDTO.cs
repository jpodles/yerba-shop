namespace YerbaShop.API.Models
{
    public class UserAuthDTO
    {
        public int id { get; set; }
        public string email { get; set; }

        public UserAuthDTO(int id, string email)
        {
            this.id = id;
            this.email = email;
        }
    }
}
