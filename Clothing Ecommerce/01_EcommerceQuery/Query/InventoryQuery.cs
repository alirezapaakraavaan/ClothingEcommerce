using System.Linq;
using _01_EcommerceQuery.Contract.InventoryQuery;
using InventoryManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_EcommerceQuery.Query
{
    public class InventoryQuery : IInventoryQuery
    {
        private readonly InventoryContext _inventoryContext;
        private readonly ShopContext _shopContext;

        public InventoryQuery(InventoryContext inventoryContext, ShopContext shopContext)
        {
            _inventoryContext = inventoryContext;
            _shopContext = shopContext;
        }

        public StockStatus CheckStock(IsInStock command)
        {
            var inventory = _inventoryContext.Inventories.FirstOrDefault(x =>
                x.ProductId == command.ProductId && x.Size == command.Size);

            var product = _shopContext.Products.Select(x => new {x.Id, x.Name})
                .FirstOrDefault(x => x.Id == command.ProductId);

            if (inventory == null || inventory.CalculateCurrentCount() < command.Count)
            {
                return new StockStatus
                {
                    IsStock = false,
                    ProductName = product?.Name
                };
            }

            return new StockStatus
            {
                IsStock = true,
                ProductName = product?.Name
            };
        }
    }
}