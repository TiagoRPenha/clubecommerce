using Ecommerce.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Mappings
{
    public class ProductImageMapping : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Url)
                .HasColumnType("varchar(130)")
                .HasMaxLength(130)
                .IsRequired();

            builder.Property(p => p.AltText)
                .HasColumnType("varchar(70)")
                .HasMaxLength(100);

            builder.Property(p => p.ProductSku)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.ToTable("Images");
        }
    }
}
