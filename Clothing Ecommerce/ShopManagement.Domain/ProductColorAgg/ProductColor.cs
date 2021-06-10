using _0_Framework.Domain;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductSizeAgg;

namespace ShopManagement.Domain.ProductColorAgg
{
    public class ProductColor : EntityBase
    {
        public string Color { get; private set; }
        public long ProductSizeId { get; private set; }
        public ProductSize ProductSize { get; private set; }
        public long ProductId { get; private set; }
        public Product Product { get; private set; }

        public ProductColor(string color, long productSizeId, long productId)
        {
            Color = color;
            ProductSizeId = productSizeId;
            ProductId = productId;
        }

        public void Edit(string color, long productSizeId, long productId)
        {
            Color = color;
            ProductSizeId = productSizeId;
            ProductId = productId;
        }
    }
}