using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.MainCategoryAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class MainCategoryMapping : IEntityTypeConfiguration<MainCategory>
    {
        public void Configure(EntityTypeBuilder<MainCategory> builder)
        {
            builder.ToTable("MainCategories");
            builder.Property(x => x.Name).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Picture).HasMaxLength(1000);
            builder.Property(x => x.PictureAlt).HasMaxLength(50);
            builder.Property(x => x.PictureTitle).HasMaxLength(50);
            builder.Property(x => x.Keywords).HasMaxLength(80);
            builder.Property(x => x.MetaDescription).HasMaxLength(150);
            builder.Property(x => x.Slug).HasMaxLength(300).IsRequired();

            builder.HasMany(x => x.ProductCategories)
                .WithOne(x => x.MainCategory).HasForeignKey(x => x.MainCategoryId);
        }
    }
}