using _01_EcommerceQuery.Contract.ArticleCategories;
using _01_EcommerceQuery.Contract.Articles;
using _01_EcommerceQuery.Query;
using BlogManagement.Application;
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Application.Contracts.ArticleCategory;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Domain.ArticleCategoryAgg;
using BlogManagement.Infrastructure.EfCore;
using BlogManagement.Infrastructure.EfCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogManagement.Infrastructure.Configuration
{
    public class BlogManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();

            services.AddTransient<IArticleCategoryQuery, ArticleCategoryQuery>();

            services.AddTransient<IArticleQuery, ArticleQuery>();

            services.AddDbContext<BlogContext>(x => x.UseSqlServer(connectionString));
        }
    }
}