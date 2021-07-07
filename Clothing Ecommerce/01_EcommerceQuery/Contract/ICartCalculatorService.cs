using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;

namespace _01_EcommerceQuery.Contract
{
    public interface ICartCalculatorService
    {
        Cart ComputeCart(List<CartItem> cartItems);
    }
}