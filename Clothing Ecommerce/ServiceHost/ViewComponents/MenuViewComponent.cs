using _01_EcommerceQuery;
using _01_EcommerceQuery.Contract.ArticleCategories;
using _01_EcommerceQuery.Contract.ProductCategories;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IProductCategoryQueryWemen _productCategoryQueryWemen;
        private readonly IProductCategoryQueryMen _productCategoryQueryMen;
        private readonly IProductCategoryQueryKids _productCategoryQueryKids;
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public MenuViewComponent(IProductCategoryQueryWemen productCategoryQueryWemen,
            IProductCategoryQueryMen productCategoryQueryMen, IProductCategoryQueryKids productCategoryQueryKids,
            IArticleCategoryQuery articleCategoryQuery)
        {
            _productCategoryQueryWemen = productCategoryQueryWemen;
            _productCategoryQueryMen = productCategoryQueryMen;
            _productCategoryQueryKids = productCategoryQueryKids;
            _articleCategoryQuery = articleCategoryQuery;
        }

        public IViewComponentResult Invoke()
        {
            var result = new MenuModel
            {
                ArticleCategories = _articleCategoryQuery.GetArticleCategories(),
                ProductCategories = _productCategoryQueryWemen.GetProductCategoriesForWemen()
            };

            return View(result);
        }
    }
}