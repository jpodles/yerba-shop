using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YerbaShop.API.Models;

namespace YerbaShop.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetUserById(string id);
        public User DeleteUserById(string id);
        public User CreateUser(User user);
        public User GetUserByEmail(string email);
    }
}
