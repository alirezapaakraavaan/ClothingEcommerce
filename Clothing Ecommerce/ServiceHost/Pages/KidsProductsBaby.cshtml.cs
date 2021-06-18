using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class KidsProductsBabyModel : PageModel
    {
        public List<ProductQueryModel> Baby;
        private readonly IProductQueryKids _productQueryKids;

        public KidsProductsBabyModel(IProductQueryKids productQueryKids)
        {
            _productQueryKids = productQueryKids;
        }

        public void OnGet()
        {
            Baby = _productQueryKids.GetBabysProducts();
        }
    }
}