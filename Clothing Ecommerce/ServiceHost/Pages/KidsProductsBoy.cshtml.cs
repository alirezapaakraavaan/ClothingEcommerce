using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class KidsProductsBoyModel : PageModel
    {
        public List<ProductQueryModel> Boy;
        private readonly IProductQueryKids _productQueryKids;

        public KidsProductsBoyModel(IProductQueryKids productQueryKids)
        {
            _productQueryKids = productQueryKids;
        }

        public void OnGet()
        {
            Boy = _productQueryKids.GetBoysProducts();
        }
    }
}
