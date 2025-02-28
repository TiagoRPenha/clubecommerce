using System.Linq.Expressions;
using Ecommerce.Business.Interfaces.Repositories;
using Ecommerce.Business.Models;
using Ecommerce.Infrastructure.ApplicationContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly EcommerceClubContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(EcommerceClubContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _dbSet.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IList<TEntity>> GetBySearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync() ?? new List<TEntity>();
        }

        public async Task InsertAsync(TEntity entity)
        {
            _dbSet.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);

            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"Entity with ID {id} not found!");
            }
        }
    }
}
