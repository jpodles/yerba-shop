using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YerbaShop.API.Models
{
    public class UserAuthDTO
    {
        public string id { get; set; }
        public string email { get; set; }

        public UserAuthDTO(string id, string email)
        {
            this.id = id;
            this.email = email;
        }
    }
}
