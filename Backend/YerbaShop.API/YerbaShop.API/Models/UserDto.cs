using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YerbaShop.API.Models
{
    public class UserDto
    {
        public string Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public UserDto(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
        }
    }
}
