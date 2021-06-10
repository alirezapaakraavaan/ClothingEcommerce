using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductPriceAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class ProductPriceMapping : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.ToTable("ProductPrices");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired();

            builder.HasOne(x => x.Product).WithMany(x => x.ProductPrices)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.ProductSize).WithMany(x => x.ProductPrices)
                .HasForeignKey(x => x.ProductSizeId);
        }
    }
}