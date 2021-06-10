namespace ShopManagement.Application.Contracts.ProductColor
{
    public class ProductColorViewModel
    {
        public long Id { get; set; }
        public string Color { get; set; }
        public string Product { get; set; }
        public string Size { get; set; }
        public long ProductId { get; set; }
    }
}