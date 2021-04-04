using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YerbaShop.API.Repositories.Interfaces;

namespace YerbaShop.API.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _yerbaShopRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository yerbaShopRepository, IMapper mapper)
        {
            _yerbaShopRepository = yerbaShopRepository ?? throw new ArgumentNullException(nameof(yerbaShopRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(yerbaShopRepository));
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var productsEntites = await _yerbaShopRepository.GetProductsAsync();
            return Ok(_mapper.Map<IEnumerable<Models.ProductShortDto>>(productsEntites));
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProduct(int productId)
        {
            var product = await _yerbaShopRepository.GetProductAsync(productId);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Models.ProductDto>(product));
        }
    }
}