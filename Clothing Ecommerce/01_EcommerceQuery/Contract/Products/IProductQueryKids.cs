using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Products
{
    public interface IProductQueryKids
    {
        List<ProductQueryModel> GetProductsForKids();
    }
}