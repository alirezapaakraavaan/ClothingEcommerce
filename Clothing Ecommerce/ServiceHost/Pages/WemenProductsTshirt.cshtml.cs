using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class WemenProductsTshirtModel : PageModel
    {
        public List<ProductQueryModel> wemenTshirt;
        private readonly IProductQueryWemen _productQueryWemen;

        public WemenProductsTshirtModel(IProductQueryWemen productQueryWemen)
        {
            _productQueryWemen = productQueryWemen;
        }

        public void OnGet()
        {
            wemenTshirt = _productQueryWemen.GetWemenTshirt();
        }
    }
}