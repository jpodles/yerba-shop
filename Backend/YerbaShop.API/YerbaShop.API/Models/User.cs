using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YerbaShop.API.Models
{
    public class User
    {
        public string Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AddressFK { get; set; }

        public User(string id)
        {
            Id = id;
        }

        public User(string id, string firstName, string lastName, string email, string password, string addressFK) : this(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            AddressFK = addressFK;
        }
    }
}
