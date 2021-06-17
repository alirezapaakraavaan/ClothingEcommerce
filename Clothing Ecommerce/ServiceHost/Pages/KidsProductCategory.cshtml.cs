using System.Collections.Generic;
using _01_EcommerceQuery.Contract.ProductCategories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class KidsProductCategoryModel : PageModel
    {
        public List<ProductCategoryQueryModel> KidsProductCategory;
        private readonly IProductCategoryQueryKids _productCategoryQueryKids;

        public KidsProductCategoryModel(IProductCategoryQueryKids productCategoryQueryKids)
        {
            _productCategoryQueryKids = productCategoryQueryKids;
        }

        public void OnGet()
        {
            KidsProductCategory = _productCategoryQueryKids.GetProductCategoriesForKids();
        }
    }
}