using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.ProductCategories
{
    public interface IProductCategoryQueryKids
    {
        List<ProductCategoryQueryModel> GetProductCategoriesForKids();
    }
}