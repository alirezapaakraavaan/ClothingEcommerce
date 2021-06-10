using _0_Framework.Domain;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductSizeAgg;

namespace ShopManagement.Domain.ProductPriceAgg
{
    public class ProductPrice : EntityBase
    {
        public double Price { get; private set; }
        public long ProductId { get; private set; }
        public Product Product { get; private set; }
        public long ProductSizeId { get; private set; }
        public ProductSize ProductSize { get; private set; }

        public ProductPrice(double price, long productId, long productSizeId)
        {
            Price = price;
            ProductId = productId;
            ProductSizeId = productSizeId;
        }

        public void Edit(double price, long productId, long productSizeId)
        {
            Price = price;
            ProductId = productId;
            ProductSizeId = productSizeId;
        }
    }
}