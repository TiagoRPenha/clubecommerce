using Ecommerce.Business.Interfaces.Repositories;
using Ecommerce.Business.Models;
using Ecommerce.Business.Services.Interfaces;

namespace Ecommerce.Business.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IBaseRepository<Product> repository) : base(repository)
        {
        }
    }
}
