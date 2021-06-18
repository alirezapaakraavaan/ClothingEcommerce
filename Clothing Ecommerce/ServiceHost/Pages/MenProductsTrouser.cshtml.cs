using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MenProductsTrouserModel : PageModel
    {
        public List<ProductQueryModel> menTrouser;
        private readonly IProductQueryMen _productQueryMen;

        public MenProductsTrouserModel(IProductQueryMen productQueryMen)
        {
            _productQueryMen = productQueryMen;
        }

        public void OnGet()
        {
            menTrouser = _productQueryMen.GetMenTrouser();
        }
    }
}