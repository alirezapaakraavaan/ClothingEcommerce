﻿namespace _01_EcommerceQuery.Contract.ArticleCategories
{
    public class ArticleCategoryQueryModel
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string PublishDate { get; set; }
        public long ArticlesCount { get; set; }
    }
}