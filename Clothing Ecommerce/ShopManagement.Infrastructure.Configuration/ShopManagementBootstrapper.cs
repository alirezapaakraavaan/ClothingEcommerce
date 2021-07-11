using _0_Framework.Infrastructure;
using _01_EcommerceQuery.Contract;
using _01_EcommerceQuery.Contract.ProductCategories;
using _01_EcommerceQuery.Contract.Products;
using _01_EcommerceQuery.Contract.Slide;
using _01_EcommerceQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.MainCategory;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Configuration.Permissions;
using ShopManagement.Domain.MainCategoryAgg;
using ShopManagement.Domain.OrderAgg;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductPictureAgg;
using ShopManagement.Domain.Services;
using ShopManagement.Domain.SlideAgg;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;
using ShopManagement.Infrastructure.InventoryAcl;

namespace ShopManagement.Configuration
{
    public class ShopManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IMainCategoryApplication, MainCategoryApplication>();
            services.AddTransient<IMainCategoryRepository, MainCategoryRepository>();

            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddTransient<IProductApplication, ProductApplication>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<IProductPictureApplication, ProductPictureApplication>();
            services.AddTransient<IProductPictureRepository, ProductPictureRepository>();

            services.AddTransient<ISlideApplication, SlideApplication>();
            services.AddTransient<ISlideRepository, SlideRepository>();

            services.AddTransient<ISlideQuery, SlideQuery>();

            services.AddTransient<IProductQueryWemen, WemenProductQuery>();

            services.AddTransient<IProductQueryMen, MenProductQuery>();

            services.AddTransient<IProductQueryKids, KidsProductQuery>();

            services.AddTransient<IProductCategoryQueryWemen, WemenProductCategoryQuery>();

            services.AddTransient<IProductCategoryQueryMen, MenProductCategoryQuery>();

            services.AddTransient<IProductCategoryQueryKids, KidsProductCategoryQuery>();

            services.AddTransient<IPermissionExposer, ShopPermissionExposer>();

            services.AddTransient<ICartCalculatorService, CartCalculatorService>();

            services.AddTransient<IOrderApplication, OrderApplication>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddSingleton<ICartService, CartService>();

            services.AddTransient<IShopInventoryAcl, ShopInventoryAcl>();

            services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
        }
    }
}