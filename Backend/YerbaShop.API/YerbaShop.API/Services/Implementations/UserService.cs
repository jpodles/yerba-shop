﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YerbaShop.API.Entities;
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

        public void CreateUser(User user)
        {
           user.Password = StringSha256Hash(user.Password);
           _userRepository.CreateUser(user);
           _userRepository.Save();
        }

        public User DeleteUserById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _userRepository.GetUserByEmail(email);
        }

        public User GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

        private string StringSha256Hash(string text) =>
        string.IsNullOrEmpty(text) ? string.Empty : BitConverter.ToString(new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(text))).Replace("-", string.Empty);
    }
}
