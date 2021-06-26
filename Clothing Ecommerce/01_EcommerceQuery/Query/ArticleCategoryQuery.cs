using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_EcommerceQuery.Contract.ArticleCategories;
using BlogManagement.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;

namespace _01_EcommerceQuery.Query
{
    public class ArticleCategoryQuery : IArticleCategoryQuery
    {
        private readonly BlogContext _context;

        public ArticleCategoryQuery(BlogContext context)
        {
            _context = context;
        }

        public List<ArticleCategoryQueryModel> GetArticleCategories()
        {
            return _context.ArticleCategories
                .Include(x=>x.Articles)
                .Where(x=>x.CreationDate <= DateTime.Now)
                .Select(x => new ArticleCategoryQueryModel
                {
                    PublishDate = x.CreationDate.ToFarsi(),
                    Description = x.Description,
                    Name = x.Name,
                    Picture = x.Picture,
                    Slug = x.Slug,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    ArticlesCount = x.Articles.Count
                }).ToList();
        }
    }
}