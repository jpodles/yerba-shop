﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using YerbaShop.API.Models;
using YerbaShop.API.Services.Interfaces;

namespace YerbaShop.API.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public List<User> GetUsers()
        {
            var user = _userService.GetUsers();
            return user;
        }
    }
}