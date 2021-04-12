using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using YerbaShop.API.Entities;
using YerbaShop.API.Models;

namespace YerbaShop.API.Services.Interfaces
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetUsers();
        public User GetUserById(string id);
        public Task<User> GetUserByEmail(string email);
        public User DeleteUserById(string id);
        public void CreateUser(User user);

        public void UpdateUser(UserUpdateDto newData, int id);
    }
}
