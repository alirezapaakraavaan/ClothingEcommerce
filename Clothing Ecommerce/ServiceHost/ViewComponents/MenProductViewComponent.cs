using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class MenProductViewComponent : ViewComponent
    {
        private readonly IProductQueryMen _productQueryMen;

        public MenProductViewComponent(IProductQueryMen productQueryMen)
        {
            _productQueryMen = productQueryMen;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productQueryMen.GetProductsForMen();
            return View(products);
        }
    }
}