using System.Collections.Generic;
using _01_EcommerceQuery.Contract.ArticleCategories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleCategoriesModel : PageModel
    {
        private readonly IArticleCategoryQuery _articleCategoryQuery;
        public List<ArticleCategoryQueryModel> ArticleCategory;

        public ArticleCategoriesModel(IArticleCategoryQuery articleCategoryQuery)
        {
            _articleCategoryQuery = articleCategoryQuery;
        }

        public void OnGet()
        {
            ArticleCategory = _articleCategoryQuery.GetArticleCategories();
        }
    }
}