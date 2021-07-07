using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;

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
        List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}