using AutoMapper;

namespace YerbaShop.API.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Entities.Product, Models.ProductShortDto>();

            CreateMap<Entities.User, Models.UserReviewDto>();
            CreateMap<Entities.Review, Models.ReviewDto>();
            CreateMap<Entities.Product, Models.ProductDto>();


        }

    }
}
