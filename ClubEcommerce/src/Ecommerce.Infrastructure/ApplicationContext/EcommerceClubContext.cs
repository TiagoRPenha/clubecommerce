using Ecommerce.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.ApplicationContext
{
    public class EcommerceClubContext : DbContext
    {
        public EcommerceClubContext(DbContextOptions<EcommerceClubContext> options) : base(options) { }

        #region DbSets
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EcommerceClubContext).Assembly);
        }
    }
}
