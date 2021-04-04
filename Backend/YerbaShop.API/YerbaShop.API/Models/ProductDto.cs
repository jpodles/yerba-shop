using System.Collections.Generic;

namespace YerbaShop.API.Models
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public double ProductWeight { get; set; }

        public string ProductImage { get; set; }

        public string ProductBrand { get; set; }

        public string Country { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public ICollection<ReviewDto> Reviews { get; set; } = new List<ReviewDto>();
    }
}