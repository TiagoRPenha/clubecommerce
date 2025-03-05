using System.Linq.Expressions;
using Ecommerce.Business.Interfaces.Repositories;
using Ecommerce.Business.Models;
using Ecommerce.Business.Services.Interfaces;

namespace Ecommerce.Business.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IList<TEntity>> GetBySearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _repository.GetBySearchAsync(predicate);
        }

        public async Task InsertAsync(TEntity entity)
        {
           await _repository.InsertAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
           await _repository.UpdateAsync(entity);
        }
        public async Task DeleteAsync(Guid id)
        {
           await _repository.DeleteAsync(id);
        }
    }
}
