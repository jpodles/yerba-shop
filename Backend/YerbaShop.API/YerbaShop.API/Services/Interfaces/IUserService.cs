using System.Collections.Generic;
using YerbaShop.API.Entities;

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
