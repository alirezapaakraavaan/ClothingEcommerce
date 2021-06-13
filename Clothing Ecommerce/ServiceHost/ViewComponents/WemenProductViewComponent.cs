using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class WemenProductViewComponent : ViewComponent
    {
        private readonly IProductQueryWemen _productQuery;

        public WemenProductViewComponent(IProductQueryWemen productQuery)
        {
            _productQuery = productQuery;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productQuery.GetProductsForWemen();
            return View(products);
        }
    }
}