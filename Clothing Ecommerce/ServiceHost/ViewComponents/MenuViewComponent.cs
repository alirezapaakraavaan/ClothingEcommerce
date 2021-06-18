using _01_EcommerceQuery.Contract.ProductCategories;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IProductCategoryQueryWemen _productCategoryQueryWemen;
        private readonly IProductCategoryQueryMen _productCategoryQueryMen;
        private readonly IProductCategoryQueryKids _productCategoryQueryKids;

        public MenuViewComponent(IProductCategoryQueryWemen productCategoryQueryWemen,
            IProductCategoryQueryMen productCategoryQueryMen, IProductCategoryQueryKids productCategoryQueryKids)
        {
            _productCategoryQueryWemen = productCategoryQueryWemen;
            _productCategoryQueryMen = productCategoryQueryMen;
            _productCategoryQueryKids = productCategoryQueryKids;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}