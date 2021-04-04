using System.Collections.Generic;
using YerbaShop.API.Entities;

namespace YerbaShop.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetUserById(int id);
        public User DeleteUserById(int id);
        public User CreateUser(User user);
        public User GetUserByEmail(string email);
    }
}
