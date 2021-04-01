using System.Collections.Generic;
using System.Threading.Tasks;

namespace YerbaShop.API.Services
{
    public interface IYerbaShopRepository
    {
        Task<IEnumerable<Entities.Product>> GetProductsAsync();
        Task<Entities.Product> GetProductAsync(int id);

    }
}
