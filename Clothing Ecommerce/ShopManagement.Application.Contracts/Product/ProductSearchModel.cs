namespace ShopManagement.Application.Contracts.Product
{
    public class ProductSearchModel
    {
        public long ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ProductCategoryName { get; set; }
    }
}