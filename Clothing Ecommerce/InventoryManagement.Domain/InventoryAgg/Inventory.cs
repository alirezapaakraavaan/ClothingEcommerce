using System.Collections.Generic;
using System.Linq;
using _0_Framework.Domain;

namespace InventoryManagement.Domain.InventoryAgg
{
    public class Inventory : EntityBase
    {
        public long ProductId { get; private set; }
        public double UnitPrice { get; private set; }
        public string Color { get; private set; }
        public string Size { get; private set; }
        public bool IsInStock { get; private set; }
        public List<InventoryOperation> Operations { get; private set; }

        public Inventory(long productId, double unitPrice, string color, string size)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Color = color;
            Size = size;
            IsInStock = false;
        }

        public void Edit(long productId, double unitPrice, string color, string size)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Color = color;
            Size = size;
        }

        public long CalculateCurrentCount()
        {
            var plus = Operations.Where(x => x.Operation).Sum(x => x.Count);
            var minus = Operations.Where(x => !x.Operation).Sum(x => x.Count);
            return plus - minus;
        }

        public void Increase(long count, string size, string color, long operatorId, string description)
        {
            var currentCount = CalculateCurrentCount() + count;
            var operation = new InventoryOperation(true, count, size, color, operatorId, currentCount, description,
                0, Id);
            Operations.Add(operation);
            IsInStock = currentCount > 0;
        }

        public void Reduce(long count, string size, string color, long operatorId, string description, long orderId)
        {
            var currentCount = CalculateCurrentCount() - count;
            var operation = new InventoryOperation(false, count, size, color, operatorId, currentCount, description,
                orderId, Id);
            Operations.Add(operation);
            IsInStock = currentCount > 0;
        }
    }
}