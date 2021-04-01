using AutoMapper;

namespace YerbaShop.API.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Entities.Product, Models.ProductShortDto>();
        }

    }
}
