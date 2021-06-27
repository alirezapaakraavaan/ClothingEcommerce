using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_EcommerceQuery.Contract.Articles;
using _01_EcommerceQuery.Contract.Products;
using BlogManagement.Infrastructure.EfCore;
using CommentManagement.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;

namespace _01_EcommerceQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;
        private readonly CommentContext _commentContext;

        public ArticleQuery(BlogContext context, CommentContext commentContext)
        {
            _context = context;
            _commentContext = commentContext;
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var article = _context.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Id = x.Id,
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
                }).FirstOrDefault(x => x.Slug == slug);

            if (!string.IsNullOrWhiteSpace(article.Keywords))
                article.KeywordsList = article.Keywords.Split(",").ToList();

            var Comments = _commentContext.Comments
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x => x.Type == CommentType.Article)
                .Where(x => x.OwnerRecordId == article.Id)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Message = x.Message,
                    Name = x.Name,
                    ParentId = x.ParentId,
                    CreationDate = x.CreationDate.ToFarsi()
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var comment in Comments)
            {
                if (comment.ParentId > 0)
                    comment.ParentName = Comments.FirstOrDefault(x => x.Id == comment.ParentId)?.Name;
            }

            article.Comments = Comments;
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