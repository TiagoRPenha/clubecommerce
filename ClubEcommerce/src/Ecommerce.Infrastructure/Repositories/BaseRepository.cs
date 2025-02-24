using System.Linq.Expressions;
using Ecommerce.Business.Interfaces.Repositories;
using Ecommerce.Business.Models;

namespace Ecommerce.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public Task<IList<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<TEntity>> GetBySearch(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
