using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class WemenProductsMantoModel : PageModel
    {
        public List<ProductQueryModel> wemenManto;
        private readonly IProductQueryWemen _productQueryWemen;

        public WemenProductsMantoModel(IProductQueryWemen productQueryWemen)
        {
            _productQueryWemen = productQueryWemen;
        }

        public void OnGet()
        {
            wemenManto = _productQueryWemen.GetWemenMantos();
        }
    }
}