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

        public JWTAuthController(IConfiguration config, ICurrentUser currentUser)
        {
            _config = config;
            _currentUser = currentUser;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] UserAuthDTO login)
        {
            IActionResult response = Unauthorized();
            var user = AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetUserInfo()
        {
            var currentUser = HttpContext.User;
            var response = Ok(_currentUser.GetLoggedInUser(currentUser));

           // var response = Ok(new List<string>(){email});
            return response;
        }

        private string GenerateJSONWebToken(UserAuthDTO userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new [] 
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

        private UserAuthDTO AuthenticateUser(UserAuthDTO login)
        {

            //Validate the User Credentials    
            //Demo Purpose, I have Passed HardCoded User Information    
            // to change when db will be available 
            if (!(login.email.Equals("bartek@email")))
            {
                throw new UnauthorizedAccessException();
            }
            return login;
        }
    }
}
