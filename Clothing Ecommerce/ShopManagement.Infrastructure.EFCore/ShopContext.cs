using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.MainCategoryAgg;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductPictureAgg;
using ShopManagement.Infrastructure.EFCore.Mapping;

namespace ShopManagement.Infrastructure.EFCore
{
    public class ShopContext : DbContext
    {
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(MainCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}