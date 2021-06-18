using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class WemenProductsUnderwearModel : PageModel
    {
        public List<ProductQueryModel> wemenUnderwear;
        private readonly IProductQueryWemen _productQueryWemen;

        public WemenProductsUnderwearModel(IProductQueryWemen productQueryWemen)
        {
            _productQueryWemen = productQueryWemen;
        }

        public void OnGet()
        {
            wemenUnderwear = _productQueryWemen.GetWemenUnderwear();
        }
    }
}