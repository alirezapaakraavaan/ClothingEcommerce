using System.Collections.Generic;
using _01_EcommerceQuery.Contract.ProductCategories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class WemenProductCategoryModel : PageModel
    {
        public List<ProductCategoryQueryModel> WemenProductCategoryQuery;
        private readonly IProductCategoryQueryWemen _productCategoryQueryWemen;

        public WemenProductCategoryModel(IProductCategoryQueryWemen productCategoryQueryWemen)
        {
            _productCategoryQueryWemen = productCategoryQueryWemen;
        }

        public void OnGet()
        {
            WemenProductCategoryQuery = _productCategoryQueryWemen.GetProductCategoriesForWemen();
        }
    }
}