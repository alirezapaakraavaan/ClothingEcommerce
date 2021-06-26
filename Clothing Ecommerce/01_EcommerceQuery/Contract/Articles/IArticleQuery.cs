using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Articles
{
    public interface IArticleQuery
    {
        ArticleQueryModel GetArticleDetails(string slug);
        List<ArticleQueryModel> GetArticles();
    }
}