using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_EcommerceQuery.Contract.Articles;
using BlogManagement.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;

namespace _01_EcommerceQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var article = _context.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Picture = x.Picture,
                    Slug = x.Slug,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Keywords = x.Keywords,
                    Description = x.Description,
                    MetaDescription = x.MetaDescription,
                    CanonicalAddress = x.CanonicalAddress,
                    CategoryId = x.CategoryId,
                    CategoryName = x.ArticleCategory.Name,
                    CategorySlug = x.ArticleCategory.Slug,
                    PublishDate = x.PublishDate.ToFarsi(),
                    Title = x.Title
                }).FirstOrDefault(x=>x.Slug == slug);

            article.KeywordsList = article.Keywords.Split(",").ToList();

            return article;
        }

        public List<ArticleQueryModel> GetArticles()
        {
            return _context.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Picture = x.Picture,
                    Slug = x.Slug,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Keywords = x.Keywords,
                    Description = x.ShortDescription,
                    MetaDescription = x.MetaDescription,
                    CanonicalAddress = x.CanonicalAddress,
                    CategoryId = x.CategoryId,
                    CategoryName = x.ArticleCategory.Name,
                    CategorySlug = x.ArticleCategory.Slug,
                    PublishDate = x.PublishDate.ToFarsi(),
                    Title = x.Title
                }).ToList();
        }
    }
}