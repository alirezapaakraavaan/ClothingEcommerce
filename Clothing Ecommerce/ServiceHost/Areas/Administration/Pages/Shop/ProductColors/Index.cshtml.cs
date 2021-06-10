using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductColor;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductColors
{
    public class IndexModel : PageModel
    {
        public SelectList Products;
        public SelectList Sizes;
        [TempData] public string Message { get; set; }
        public ProductColorSearchModel SearchModel;
        public List<ProductColorViewModel> ProductColors;
        private readonly IProductApplication _productApplication;
        private readonly IProductColorApplication _productColorApplication;

        public IndexModel(IProductApplication productApplication, IProductColorApplication productColorApplication)
        {
            _productApplication = productApplication;
            _productColorApplication = productColorApplication;
        }

        public void OnGet(ProductColorSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            Sizes = new SelectList(_productApplication.GetProductSizes(), "Id", "Size");
            ProductColors = _productColorApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProductColor
            {
                Products = _productApplication.GetProducts(),
                Sizes = _productApplication.GetProductSizes()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProductColor command)
        {
            var result = _productColorApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var product = _productColorApplication.GetDetails(id);
            product.Products = _productApplication.GetProducts();
            product.Sizes = _productApplication.GetProductSizes();
            return Partial("./Edit", product);
        }

        public JsonResult OnPostEdit(EditProductColor command)
        {
            var result = _productColorApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}