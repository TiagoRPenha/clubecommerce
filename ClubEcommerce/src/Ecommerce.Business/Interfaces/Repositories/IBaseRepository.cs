using System.Linq.Expressions;
using Ecommerce.Business.Models;

namespace Ecommerce.Business.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<IList<TEntity>> GetBySearchAsync(Expression<Func<TEntity, bool>> predicate);
        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);    
        Task DeleteAsync(Guid id);
    }
}
