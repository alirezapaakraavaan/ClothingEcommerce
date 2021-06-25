using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.ArticleCategories
{
    public interface IArticleCategoryQuery
    {
        List<ArticleCategoryQueryModel> GetArticleCategories();
    }
}