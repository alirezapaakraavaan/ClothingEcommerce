using System.Collections.Generic;
using _01_EcommerceQuery.Contract.ArticleCategories;
using _01_EcommerceQuery.Contract.ProductCategories;

namespace _01_EcommerceQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}