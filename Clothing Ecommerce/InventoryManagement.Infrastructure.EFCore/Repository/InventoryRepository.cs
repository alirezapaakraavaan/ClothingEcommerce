using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Infrastructure.EfCore;
using InventoryManagement.Application.Contracts;
using InventoryManagement.Domain.InventoryAgg;
using ShopManagement.Infrastructure.EFCore;

namespace InventoryManagement.Infrastructure.EFCore.Repository
{
    public class InventoryRepository : RepositoryBase<long, Inventory>, IInventoryRepository
    {
        private readonly InventoryContext _context;
        private readonly ShopContext _shopContext;
        private readonly AccountContext _accountContext;

        public InventoryRepository(InventoryContext context, ShopContext shopContext, AccountContext accountContext) :
            base(context)
        {
            _context = context;
            _shopContext = shopContext;
            _accountContext = accountContext;
        }

        public EditInventory GetDetails(long id)
        {
            return _context.Inventories.Select(x => new EditInventory
            {
                Id = x.Id,
                Size = x.Size,
                Color = x.Color,
                ProductId = x.ProductId,
                UnitPrice = x.UnitProductPrice
            }).FirstOrDefault(x => x.Id == id);
        }

        public Inventory GetBy(long productId, string size)
        {
            return _context.Inventories.FirstOrDefault(x => x.ProductId == productId && x.Size == size);
        }

        public List<InventoryViewModel> Search(InventorySearchModel searchModel)
        {
            var products = _shopContext.Products.Select(x => new {x.Id, x.Name}).ToList();
            var query = _context.Inventories.Select(x => new InventoryViewModel
            {
                IsInStock = x.IsInStock,
                Size = x.Size,
                Color = x.Color,
                ProductId = x.ProductId,
                UnitPrice = x.UnitProductPrice,
                Id = x.Id,
                CurrentCount = x.CalculateCurrentCount()
            });

            if (searchModel.ProductId > 0)
                query = query.Where(x => x.ProductId == searchModel.ProductId);

            if (searchModel.IsInStock)
                query = query.Where(x => !x.IsInStock);

            var inventory = query.OrderByDescending(x => x.Id).ToList();

            inventory.ForEach(item => { item.Product = products.FirstOrDefault(x => x.Id == item.ProductId)?.Name; });

            return inventory;
        }

        public List<InventoryOperationViewModel> GetOperationLog(long inventoryId)
        {
            var accounts = _accountContext.Accounts.Select(x => new {x.Id, x.Fullname});
            var inventory = _context.Inventories.FirstOrDefault(x => x.Id == inventoryId);
            var operations = inventory.Operations.Select(x => new InventoryOperationViewModel
            {
                Id = x.Id,
                Size = x.Size,
                Color = x.Color,
                Description = x.Description,
                Count = x.Count,
                CurrentCount = x.CurrentCount,
                Operation = x.Operation,
                OperationDate = x.OperationDate.ToFarsi(),
                OperatorId = x.OperatorId,
                OrderId = x.OrderId
            }).OrderByDescending(x => x.Id).ToList();

            foreach (var operation in operations)
            {
                operation.Operator = accounts.FirstOrDefault(x => x.Id == operation.OperatorId)?.Fullname;
            }

            return operations;
        }
    }
}