using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductSize;

namespace ShopManagement.Application.Contracts.ProductPrice
{
    public class CreateProductPrice
    {
        public double Price { get; set; }
        public long ProductId { get; set; }
        public long ProductSizeId { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public List<ProductSizeViewModel> Sizes { get; set; }
    }
}