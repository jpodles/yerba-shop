using System.Collections.Generic;
using System.Threading.Tasks;
using YerbaShop.API.Entities;
using YerbaShop.API.Models;

namespace YerbaShop.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetUsers();
        public Task<User> GetUserById(int id);
        public Task<User> DeleteUserById(int id);
        public void CreateUser(User user);
        public Task<User> GetUserByEmail(string email);
        public bool Save();

        public void UpdateUser(User user);
    }
}
