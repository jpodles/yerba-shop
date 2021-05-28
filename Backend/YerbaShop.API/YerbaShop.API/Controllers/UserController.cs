using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using YerbaShop.API.Entities;
using YerbaShop.API.Models;
using YerbaShop.API.Services.Interfaces;

namespace YerbaShop.API.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private readonly IMapper _mapper;
        private ICurrentUser _currentUser;

        public UserController(IUserService userService, IMapper mapper, ICurrentUser currentUser)
        {
            _userService = userService;
            _mapper = mapper;
            _currentUser = currentUser;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetUsers()
        {
            var user = await _userService.GetUsers();
            return Ok(_mapper.Map<UserDto>(user));
        }

        [HttpPost("/register")]
        public async Task<IActionResult> CreateUser([FromBody]UserRegistrationDto user)
        {
            var userToSave = _mapper.Map<User>(user);
            _userService.CreateUser(userToSave);
            return Ok(_mapper.Map<UserDto>(userToSave));
        }

        [HttpPatch]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> UpdateUser(UserUpdateDto newData)
        {
            var currentUser = HttpContext.User;
            var user = await _currentUser.GetLoggedInUser(currentUser);
            _userService.UpdateUser(newData, user.Id);
            return Ok(_mapper.Map<UserDto>(newData));
        }
    }
}
