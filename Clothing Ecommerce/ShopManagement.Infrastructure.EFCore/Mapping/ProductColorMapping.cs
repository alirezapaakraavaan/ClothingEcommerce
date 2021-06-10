using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductColorAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class ProductColorMapping : IEntityTypeConfiguration<ProductColor>
    {
        public void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            builder.ToTable("ProductColors");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Color).HasMaxLength(60).IsRequired();

            builder.HasOne(x => x.Product).WithMany(x => x.ProductColors)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.ProductSize).WithMany(x => x.ProductColors)
                .HasForeignKey(x => x.ProductSizeId);
        }
    }
}