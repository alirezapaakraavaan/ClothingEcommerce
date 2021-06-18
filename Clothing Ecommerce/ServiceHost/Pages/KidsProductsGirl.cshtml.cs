using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class KidsProductsGirlModel : PageModel
    {
        public List<ProductQueryModel> Girl;
        private readonly IProductQueryKids _productQueryKids;

        public KidsProductsGirlModel(IProductQueryKids productQueryKids)
        {
            _productQueryKids = productQueryKids;
        }

        public void OnGet()
        {
            Girl = _productQueryKids.GetGirlsProducts();
        }
    }
}