using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class KidsProductViewComponent : ViewComponent
    {
        private readonly IProductQueryKids _productQueryKids;

        public KidsProductViewComponent(IProductQueryKids productQueryKids)
        {
            _productQueryKids = productQueryKids;
        }

        public IViewComponentResult Invoke()
        {
            var product = _productQueryKids.GetProductsForKids();
            return View(product);
        }
    }
}