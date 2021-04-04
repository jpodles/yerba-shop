using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using YerbaShop.API.Contexts;
using YerbaShop.API.Entities;
using YerbaShop.API.Repositories.Interfaces;

namespace YerbaShop.API.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private YerbaShopContext _context;

        public ProductRepository(YerbaShopContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddReview(Review review)
        {
            if (review == null)
            {
                throw new ArgumentNullException(nameof(review));
            }

            _context.Reviews.Add(review);
        }

        public void DeleteReview(int reviewId)
        {
            if (reviewId == 0)
            {
                throw new ArgumentNullException(nameof(reviewId));
            }

            _context.Remove(_context.Reviews.First(r => r.Id == reviewId));
            _context.SaveChanges();
        }

        public async Task<Product> GetProductAsync(int id)
        {
            return await _context.Products
                .Include(p => p.Reviews).ThenInclude(r => r.User)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public Review GetReviewById(int reviewId)
        {
            return _context.Reviews.FirstOrDefault(r => r.Id == reviewId);
        }

        public bool ProductExists(int productId)
        {
            if (productId == 0)
            {
                throw new ArgumentNullException(nameof(productId));
            }

            return _context.Products.Any(p => p.Id == productId);
        }

        public bool ReviewExists(int reviewId)
        {
            if (reviewId == 0)
            {
                throw new ArgumentNullException(nameof(reviewId));
            }

            return _context.Reviews.Any(r => r.Id == reviewId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateReview(int productId, int reviewId, Review review)
        {
            if (review == null)
            {
                throw new ArgumentNullException(nameof(reviewId));
            }

            _context.Reviews.Update(review);
            _context.SaveChanges();


        }
    }
}