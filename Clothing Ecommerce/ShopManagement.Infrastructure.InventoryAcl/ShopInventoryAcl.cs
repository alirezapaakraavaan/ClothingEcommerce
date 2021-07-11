using System.Collections.Generic;
using System.Linq;
using InventoryManagement.Application.Contracts;
using ShopManagement.Domain.OrderAgg;
using ShopManagement.Domain.Services;

namespace ShopManagement.Infrastructure.InventoryAcl
{
    public class ShopInventoryAcl : IShopInventoryAcl
    {
        private readonly IInventoryApplication _inventoryApplication;

        public ShopInventoryAcl(IInventoryApplication inventoryApplication)
        {
            _inventoryApplication = inventoryApplication;
        }

        public bool ReduceFromInventory(List<OrderItem> items)
        {
            var command = items.Select(orderItem => new ReduceInventory(orderItem.InventoryId, orderItem.Color,
                orderItem.Count, "خرید مشتری", orderItem.OrderId, orderItem.ProductId, orderItem.Size)).ToList();

            return _inventoryApplication.Reduce(command).IsSucceeded;
        }
    }
}