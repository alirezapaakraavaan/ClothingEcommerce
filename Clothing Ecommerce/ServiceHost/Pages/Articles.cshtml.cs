using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Articles;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticlesModel : PageModel
    {
        private readonly IArticleQuery _articleQuery;
        public List<ArticleQueryModel> Article;

        public ArticlesModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet()
        {
            Article = _articleQuery.GetArticles();
        }
    }
}