using _0_Framework.Domain;

namespace ShopManagement.Domain.OrderAgg
{
    public class OrderItem : EntityBase
    {
        public long InventoryId { get; private set; }
        public long ProductId { get; private set; }
        public int Count { get; private set; }
        public double UnitProductPrice { get; private set; }
        public string Size { get; private set; }
        public string Color { get; private set; }
        public int DiscountRate { get; private set; }
        public long OrderId { get; private set; }
        public Order Order { get; private set; }

        public OrderItem(long inventoryId, int count, int discountRate, long productId, double unitProductPrice, string size,
            string color)
        {
            InventoryId = inventoryId;
            Count = count;
            DiscountRate = discountRate;
            ProductId = productId;
            UnitProductPrice = unitProductPrice;
            Size = size;
            Color = color;
        }
    }
}