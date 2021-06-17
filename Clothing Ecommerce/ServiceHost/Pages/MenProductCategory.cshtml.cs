using System.Collections.Generic;
using _01_EcommerceQuery.Contract.ProductCategories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MenProductCategoryModel : PageModel
    {
        public List<ProductCategoryQueryModel> MenProductCategory;
        private readonly IProductCategoryQueryMen _productCategoryQueryMen;

        public MenProductCategoryModel(IProductCategoryQueryMen productCategoryQueryMen)
        {
            _productCategoryQueryMen = productCategoryQueryMen;
        }

        public void OnGet()
        {
            MenProductCategory = _productCategoryQueryMen.GetProductCategoriesForMen();
        }
    }
}