using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Products
{
    public interface IProductQueryWemen
    {
        List<ProductQueryModel> GetProductsForWemen();
        List<ProductQueryModel> GetWemenMantos();
        List<ProductQueryModel> GetWemenBoluz();
        List<ProductQueryModel> GetWemenTshirt();
        List<ProductQueryModel> GetWemenTrouser();
        List<ProductQueryModel> GetWemenUnderwear();
        List<ProductQueryModel> Search(string value);
        ProductQueryModel GetDetails(string slug, string size, string color);
    }
}