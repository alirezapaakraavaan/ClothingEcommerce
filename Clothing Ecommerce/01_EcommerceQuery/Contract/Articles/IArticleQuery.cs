using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Articles
{
    public interface IArticleQuery
    {
        List<ArticleQueryModel> GetArticles();
    }
}