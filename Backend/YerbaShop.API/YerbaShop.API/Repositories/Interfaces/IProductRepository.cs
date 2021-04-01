using System.Collections.Generic;
using System.Threading.Tasks;

namespace YerbaShop.API.Repositories.Intefraces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Entities.Product>> GetProductsAsync();
        Task<Entities.Product> GetProductAsync(int id);

    }
}
