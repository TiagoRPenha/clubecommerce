using Ecommerce.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Sku);

            builder.Property(p => p.Sku)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Name)
                .HasColumnType("varchar(70)")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(p => p.Images)
                .WithOne(i => i.Product)
                .HasForeignKey(i => i.ProductSku)
                .HasPrincipalKey(p => p.Sku);

            builder.ToTable("Products");
        }
    }
}
