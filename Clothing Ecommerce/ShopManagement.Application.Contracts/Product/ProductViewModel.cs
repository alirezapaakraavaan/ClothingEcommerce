namespace ShopManagement.Application.Contracts.Product
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double UnitPrice { get; set; }
        public string Picture { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string ProductCategoryName { get; set; }
        public long ProductCategoryId { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsInStock { get; set; }
    }
}