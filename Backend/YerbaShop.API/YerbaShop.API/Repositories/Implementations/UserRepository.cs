using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YerbaShop.API.Contexts;
using YerbaShop.API.Entities;
using YerbaShop.API.Repositories.Interfaces;

namespace YerbaShop.API.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private YerbaShopContext _context;

        public UserRepository(YerbaShopContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public  void CreateUser(User user)
        {
            _context.Users.Add(user);
        }

        public Task<User> DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users
               .FirstOrDefaultAsync(p => p.Email == email);
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.Users
               .FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
