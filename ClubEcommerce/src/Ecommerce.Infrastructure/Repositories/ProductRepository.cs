using Ecommerce.Business.Interfaces.Repositories;
using Ecommerce.Business.Models;
using Ecommerce.Infrastructure.ApplicationContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(EcommerceClubContext context) : base(context) { }

        public async Task<Product?> GetBySku(string sku)
        {
            return await _dbSet.SingleOrDefaultAsync(p => p.Sku.Equals(sku));
        }
    }
}
