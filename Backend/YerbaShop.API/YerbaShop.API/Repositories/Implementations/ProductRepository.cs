using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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


    }
}
