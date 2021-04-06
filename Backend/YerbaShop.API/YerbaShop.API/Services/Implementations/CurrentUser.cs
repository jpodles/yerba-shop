﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using YerbaShop.API.Models;
using YerbaShop.API.Services.Interfaces;

namespace YerbaShop.API.Services.Implementations
{
    public class CurrentUser : ICurrentUser
    {
        private IUserService _userService;
        private IMapper _mapper;

        public CurrentUser(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public UserDto GetLoggedInUser(ClaimsPrincipal claims)
        {
            var email = claims.Claims.FirstOrDefault(x => x.Type.Contains("emailaddress")).Value;

            var user = _userService.GetUserByEmail(email);

            return _mapper.Map<UserDto>(user);
        }
    }
}
