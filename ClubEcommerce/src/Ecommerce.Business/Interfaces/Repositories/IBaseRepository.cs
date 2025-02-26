using System.Linq.Expressions;
using Ecommerce.Business.Models;

namespace Ecommerce.Business.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IList<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task<IList<TEntity>> GetBySearch(Expression<Func<TEntity, bool>> predicate);
        Task Insert(TEntity entity);
        Task Update(TEntity entity);    
        Task Delete(Guid id);
    }
}
