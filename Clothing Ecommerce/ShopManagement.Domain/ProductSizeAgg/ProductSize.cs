using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductColorAgg;
using ShopManagement.Domain.ProductPriceAgg;

namespace ShopManagement.Domain.ProductSizeAgg
{
    public class ProductSize : EntityBase
    {
        public string Size { get; private set; }
        public long ProductId { get; private set; }
        public Product Product { get; private set; }
        public List<ProductColor> ProductColors { get; private set; }
        public List<ProductPrice> ProductPrices { get; private set; }

        public ProductSize(string size, long productId)
        {
            Size = size;
            ProductId = productId;
        }

        public void Edit(string size, long productId)
        {
            Size = size;
            ProductId = productId;
        }
    }
}