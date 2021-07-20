namespace ShopManagement.Application.Contracts.Order
{
    public class OrderItemViewModel
    {
        public long InventoryId { get; set; }
        public string Product { get; set; }
        public long ProductId { get; set; }
        public int Count { get; set; }
        public double UnitProductPrice { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int DiscountRate { get; set; }
        public long OrderId { get; set; }
        public string OrderDate { get; set; }
    }
}