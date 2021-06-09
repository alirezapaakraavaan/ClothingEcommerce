using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Code).HasMaxLength(150).IsRequired();
            builder.Property(x => x.ShortDescription).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(1500);
            builder.Property(x => x.Picture).HasMaxLength(1000);
            builder.Property(x => x.Color).HasMaxLength(30);
            builder.Property(x => x.Size).HasMaxLength(10);
            builder.Property(x => x.Slug).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Keywords).HasMaxLength(100).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(150).IsRequired();

            builder.HasOne(x => x.ProductCategory).WithMany(x => x.Products)
                .HasForeignKey(x => x.ProductCategoryId);
        }
    }
}