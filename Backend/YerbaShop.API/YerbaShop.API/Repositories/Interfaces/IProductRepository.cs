using System.Collections.Generic;
using System.Threading.Tasks;

using YerbaShop.API.Entities;

namespace YerbaShop.API.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductAsync(int id);

        Review GetReviewById(int reviewId);

        void AddReview(Review review);
        bool Save();

        bool ProductExists(int productId);
        bool ReviewExists(int reviewId);

        void DeleteReview(int reviewId);
        void UpdateReview(int productId, int reviewId, Review reviewEntity);
    }
}