using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductSize;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductSizes
{
    public class IndexModel : PageModel
    {
        public SelectList Products;
        [TempData] public string Message { get; set; }
        public ProductSizeSearchModel SearchModel;
        public List<ProductSizeViewModel> ProductSizes;
        private readonly IProductApplication _productApplication;
        private readonly IProductSizeApplication _productSizeApplication;

        public IndexModel(IProductApplication productApplication, IProductSizeApplication productSizeApplication)
        {
            _productApplication = productApplication;
            _productSizeApplication = productSizeApplication;
        }

        public void OnGet(ProductSizeSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id",
                "Name");
            ProductSizes = _productSizeApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProductSize
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProductSize command)
        {
            var result = _productSizeApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var product = _productSizeApplication.GetDetails(id);
            product.Products = _productApplication.GetProducts();
            return Partial("./Edit", product);
        }

        public JsonResult OnPostEdit(EditProductSize command)
        {
            var result = _productSizeApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}