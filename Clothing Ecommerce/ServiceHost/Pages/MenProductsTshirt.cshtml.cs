using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MenProductsTshirtModel : PageModel
    {
        public List<ProductQueryModel> menTshirt;
        private readonly IProductQueryMen _productQueryMen;

        public MenProductsTshirtModel(IProductQueryMen productQueryMen)
        {
            _productQueryMen = productQueryMen;
        }

        public void OnGet()
        {
            menTshirt = _productQueryMen.GetMenTshirt();
        }
    }
}