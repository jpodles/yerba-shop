using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YerbaShop.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.User, Models.UserDto>();
            CreateMap< Models.UserDto, Entities.User>();
            CreateMap<Entities.User, Models.UserAuthDTO>();
            CreateMap<Entities.User, Models.UserRegistrationDto>();
            CreateMap<Models.UserRegistrationDto, Entities.User>();

        }
    }
}
