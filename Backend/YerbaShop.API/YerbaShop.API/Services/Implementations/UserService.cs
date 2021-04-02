using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YerbaShop.API.Models;
using YerbaShop.API.Repositories.Interfaces;
using YerbaShop.API.Services.Interfaces;

namespace YerbaShop.API.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User DeleteUserById(string id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public User GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        User IUserService.DeleteUserById(string id)
        {
            throw new NotImplementedException();
        }

        User IUserService.GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        List<User> IUserService.GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
