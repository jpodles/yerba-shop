using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using YerbaShop.API.Models;
using YerbaShop.API.Services.Interfaces;

namespace YerbaShop.API.Controllers
{
    [Route("api/jwt")]
    [ApiController]
    public class JWTAuthController : ControllerBase
    {
        private IConfiguration _config;
        private ICurrentUser _currentUser;
        private IUserService _userService;
        private IMapper _mapper;
        public JWTAuthController(IConfiguration config, ICurrentUser currentUser, IUserService userService, IMapper mapper)
        {
            _config = config;
            _currentUser = currentUser;
            _userService = userService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserAuthDTO login)
        {
            IActionResult response = Unauthorized();
            var user = await AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetUserInfo()
        {
            var currentUser = HttpContext.User;
            var user = await _currentUser.GetLoggedInUser(currentUser);

            return Ok(_mapper.Map<UserDto>(user));
        }

        private string GenerateJSONWebToken(UserAuthDTO userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, userInfo.email)
            };


            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task<UserAuthDTO> AuthenticateUser(UserAuthDTO login)
        {
            var user = await _userService.GetUserByEmail(login.email);
            login.password = StringSha256Hash(login.password);

            if(user is null  || user.Password != login.password ) throw new UnauthorizedAccessException();
          
            return login;
        }


        private string StringSha256Hash(string text) =>
       string.IsNullOrEmpty(text) ? string.Empty : BitConverter.ToString(new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(text))).Replace("-", string.Empty);
    }
}
