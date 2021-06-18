using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class WemenProductsBoluzModel : PageModel
    {
        public List<ProductQueryModel> WemenBoluz;
        private readonly IProductQueryWemen _productQueryWemen;

        public WemenProductsBoluzModel(IProductQueryWemen productQueryWemen)
        {
            _productQueryWemen = productQueryWemen;
        }

        public void OnGet()
        {
            WemenBoluz = _productQueryWemen.GetWemenBoluz();
        }
    }
}