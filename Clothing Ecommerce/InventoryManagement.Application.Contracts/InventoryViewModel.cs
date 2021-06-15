namespace InventoryManagement.Application.Contracts
{
    public class InventoryViewModel
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public bool IsInStock { get; set; }
        public long CurrentCount { get; set; }
    }
}