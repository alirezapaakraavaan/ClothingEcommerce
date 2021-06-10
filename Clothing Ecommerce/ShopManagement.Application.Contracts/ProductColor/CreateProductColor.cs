using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductSize;

namespace ShopManagement.Application.Contracts.ProductColor
{
    public class CreateProductColor
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Color { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Size { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public long ProductSizeId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public long ProductId { get; set; }

        public List<ProductViewModel> Products { get; set; }
        public List<ProductSizeViewModel> Sizes { get; set; }
    }
}