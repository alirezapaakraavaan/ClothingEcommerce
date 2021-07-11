namespace InventoryManagement.Application.Contracts
{
    public class ReduceInventory
    {
        public long InventoryId { get; set; }
        public long ProductId { get; set; }
        public long Count { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public long OrderId { get; set; }

        public ReduceInventory()
        {
        }

        public ReduceInventory(long inventoryId, string color, long count, string description, long orderId,
            long productId, string size)
        {
            InventoryId = inventoryId;
            Color = color;
            Count = count;
            Description = description;
            OrderId = orderId;
            ProductId = productId;
            Size = size;
        }
    }
}