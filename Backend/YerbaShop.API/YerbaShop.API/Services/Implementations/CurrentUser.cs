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

        public CurrentUser(IUserService userService)
        {
            _userService = userService;
        }

        public UserDto GetLoggedInUser(ClaimsPrincipal claims)
        {
            var email = claims.Claims.FirstOrDefault(x => x.Type.Contains("emailaddress")).Value;

            var user = _userService.GetUserByEmail(email);

            return new UserDto(user);
        }
    }
}
