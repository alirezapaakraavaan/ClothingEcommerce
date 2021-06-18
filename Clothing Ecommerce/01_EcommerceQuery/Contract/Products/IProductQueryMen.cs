using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Products
{
    public interface IProductQueryMen
    {
        List<ProductQueryModel> GetProductsForMen();
        List<ProductQueryModel> GetMenTshirt();
        List<ProductQueryModel> GetMenShirt();
        List<ProductQueryModel> GetMenTrouser();
        List<ProductQueryModel> GetMenUnderwear();
    }
}