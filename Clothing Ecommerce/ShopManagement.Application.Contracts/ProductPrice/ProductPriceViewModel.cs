namespace ShopManagement.Application.Contracts.ProductPrice
{
    public class ProductPriceViewModel
    {
        public long Id { get; set; }
        public double Price { get; set; }
        public string Product { get; set; }
        public string Size { get; set; }
        public long ProductId { get; set; }
    }
}