using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;

namespace ShopManagement.Application.Contracts.ProductSize
{
    public class CreateProductSize
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Size { get; set; }

        [Range(1, 10000, ErrorMessage = ValidationMessages.IsRequired)]
        public long ProductId { get; set; }

        public List<ProductViewModel> Products { get; set; }
    }
}