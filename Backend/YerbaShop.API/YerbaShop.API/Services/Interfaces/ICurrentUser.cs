using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using YerbaShop.API.Models;

namespace YerbaShop.API.Services.Interfaces
{
    public interface ICurrentUser
    {
        public UserDto GetLoggedInUser(ClaimsPrincipal claims);
    }
}
