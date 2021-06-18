using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class WemenProductsTrouserModel : PageModel
    {
        public List<ProductQueryModel> wemenTrouser;
        private readonly IProductQueryWemen _productQueryWemen;

        public WemenProductsTrouserModel(IProductQueryWemen productQueryWemen)
        {
            _productQueryWemen = productQueryWemen;
        }

        public void OnGet()
        {
            wemenTrouser = _productQueryWemen.GetWemenTrouser();
        }
    }
}