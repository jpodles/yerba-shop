using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YerbaShop.API.Models;
using YerbaShop.API.Repositories.Interfaces;

namespace YerbaShop.API.Repositories.Implementations
{
    public class UserRepositoryPlaceholder : IUserRepository
    {
        private List<User> exampleData;

        public UserRepositoryPlaceholder()
        {
            exampleData = new List<User>();
            var exampleUser1 = new User("1", "Bartek", "Chodak", "bartek@email", "strongPassw0rd", "1"); ;
            var exampleUser2 = new User("2", "Marcin", "Drzewo", "marcin@email", "ezPass", "2"); 

            exampleData.Add(exampleUser1);
            exampleData.Add(exampleUser2);
        }

        public User CreateUser(User user)
        {
            if (user == null) throw new NullReferenceException("User cannot be null");
            else 
            exampleData.Add(user);
            return user;
        }

        public User DeleteUserById(string id)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(string id)
        {
            return exampleData.Find(x => x.Id.Equals(id));
        }

        public List<User> GetUsers()
        {
            return exampleData;
        }
    }
}
