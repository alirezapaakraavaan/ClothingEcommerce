namespace _01_EcommerceQuery.Contract.InventoryQuery
{
    public class IsInStock
    {
        public long ProductId { get; set; }
        public string Size { get; set; }
        public int Count { get; set; }
    }
}