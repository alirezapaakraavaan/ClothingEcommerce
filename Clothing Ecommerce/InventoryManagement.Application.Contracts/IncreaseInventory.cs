namespace InventoryManagement.Application.Contracts
{
    public class IncreaseInventory
    {
        public long InventoryId { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public long Count { get; set; }
        public string Description { get; set; }
    }
}