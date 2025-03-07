using Ecommerce.Business.Interfaces.Repositories;
using Ecommerce.Business.Models;
using Ecommerce.Business.Services.Interfaces;

namespace Ecommerce.Business.Services
{
    public class ProductImageService : BaseService<ProductImage>, IProductImageService
    {
        public ProductImageService(IBaseRepository<ProductImage> repository) : base(repository)
        {
        }
    }
}
