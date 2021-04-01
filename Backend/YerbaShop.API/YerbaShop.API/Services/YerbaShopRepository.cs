using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YerbaShop.API.Contexts;
using YerbaShop.API.Entities;

namespace YerbaShop.API.Services
{
    public class YerbaShopRepository : IYerbaShopRepository
    {
        private YerbaShopContext _context;

        public YerbaShopRepository(YerbaShopContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Product> GetProductAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
