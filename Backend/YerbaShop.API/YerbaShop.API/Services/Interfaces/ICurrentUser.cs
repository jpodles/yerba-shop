using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using YerbaShop.API.Entities;
using YerbaShop.API.Models;

namespace YerbaShop.API.Services.Interfaces
{
    public interface ICurrentUser
    {
        public Task<User> GetLoggedInUser(ClaimsPrincipal claims);
    }
}
