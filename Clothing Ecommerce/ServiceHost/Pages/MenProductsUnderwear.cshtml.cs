using System.Collections.Generic;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MenProductsUnderwearModel : PageModel
    {
        public List<ProductQueryModel> menUnderwear;
        private readonly IProductQueryMen _productQueryMen;

        public MenProductsUnderwearModel(IProductQueryMen productQueryMen)
        {
            _productQueryMen = productQueryMen;
        }

        public void OnGet()
        {
            menUnderwear = _productQueryMen.GetMenUnderwear();
        }
    }
}