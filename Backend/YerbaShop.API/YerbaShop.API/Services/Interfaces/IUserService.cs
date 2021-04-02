using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YerbaShop.API.Models;

namespace YerbaShop.API.Services.Interfaces
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUserById(string id);
        public User GetUserByEmail(string email);
        public User DeleteUserById(string id);
        public User CreateUser(User user);
    }
}
