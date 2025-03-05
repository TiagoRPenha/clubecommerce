using Ecommerce.Business.Models;

namespace Ecommerce.Business.Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<Product?> GetBySku(string sku);
    }
}
