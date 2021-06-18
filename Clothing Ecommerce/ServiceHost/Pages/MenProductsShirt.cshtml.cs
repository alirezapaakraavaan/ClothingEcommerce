using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MenProductsShirtModel : PageModel
    {
        public List<ProductQueryModel> menShirt;
        private readonly IProductQueryMen _productQueryMen;

        public MenProductsShirtModel(IProductQueryMen productQueryMen)
        {
            _productQueryMen = productQueryMen;
        }

        public void OnGet()
        {
            menShirt = _productQueryMen.GetMenShirt();
        }
    }
}