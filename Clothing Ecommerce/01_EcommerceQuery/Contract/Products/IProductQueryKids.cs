using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Products
{
    public interface IProductQueryKids
    {
        List<ProductQueryModel> GetProductsForKids();
        List<ProductQueryModel> GetGirlsProducts();
        List<ProductQueryModel> GetBoysProducts();
        List<ProductQueryModel> GetBabysProducts();
    }
}