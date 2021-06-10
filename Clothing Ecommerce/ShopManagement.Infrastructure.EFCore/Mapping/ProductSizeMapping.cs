using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductSizeAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class ProductSizeMapping : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.ToTable("ProductSizes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Size).HasMaxLength(20).IsRequired();

            builder.HasOne(x => x.Product).WithMany(x => x.ProductSizes)
                .HasForeignKey(x => x.ProductId);

            builder.HasMany(x => x.ProductColors).WithOne(x => x.ProductSize)
                .HasForeignKey(x => x.ProductSizeId);
        }
    }
}