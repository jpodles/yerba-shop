using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

using YerbaShop.API.Models;
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
            _yerbaShopRepository = yerbaShopRepository
                ?? throw new ArgumentNullException(nameof(yerbaShopRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(yerbaShopRepository));

        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var productsEntites = await _yerbaShopRepository.GetProductsAsync();
            return Ok(_mapper.Map<IEnumerable<ProductShortDto>>(productsEntites));

        }

        [HttpGet("{productId}", Name = "GetProduct")]
        public async Task<IActionResult> GetProduct(int productId)
        {
            var product = await _yerbaShopRepository.GetProductAsync(productId);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDto>(product));
        }

        [HttpPost("{productId}/review")]
        public IActionResult CreateReview(int productId, [FromBody] ReviewCreationDto review)
        {
            review.ProductId = productId;
            var reviewEntity = _mapper.Map<Entities.Review>(review);
            _yerbaShopRepository.AddReview(reviewEntity);
            _yerbaShopRepository.Save();

            return Ok();
        }

        [HttpDelete("{productId}/review/{reviewId}")]
        public IActionResult DeleteReview(int productId, int reviewId)
        {
            if (!_yerbaShopRepository.ProductExists(productId))
            {
                return NotFound();
            }

            if (!_yerbaShopRepository.ReviewExists(reviewId))
            {
                return NotFound();
            }

            _yerbaShopRepository.DeleteReview(reviewId);

            return NoContent();
        }

        [HttpPatch("{productId}/review/{reviewId}")]
        public IActionResult EditReview(int productId, int reviewId,
            [FromBody] JsonPatchDocument<ReviewEditDto> reviewPatchDoc)
        {
            if (!_yerbaShopRepository.ProductExists(productId))
            {
                return NotFound();
            }

            if (!_yerbaShopRepository.ReviewExists(reviewId))
            {
                return NotFound();
            }

            var reviewEntity = _yerbaShopRepository.GetReviewById(reviewId);
            var reviewToPatch = _mapper.Map<ReviewEditDto>(reviewEntity);

            reviewPatchDoc.ApplyTo(reviewToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(reviewToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(reviewToPatch, reviewEntity);
            _yerbaShopRepository.UpdateReview(productId, reviewId, reviewEntity);

            _yerbaShopRepository.Save();

            return NoContent();
        }
    }
}