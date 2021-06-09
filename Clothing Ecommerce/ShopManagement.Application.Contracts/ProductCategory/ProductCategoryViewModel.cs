namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class ProductCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string MainCategoryName { get; set; }
        public bool IsRemoved { get; set; }
        public long MainCategoryId { get; set; }
    }
}