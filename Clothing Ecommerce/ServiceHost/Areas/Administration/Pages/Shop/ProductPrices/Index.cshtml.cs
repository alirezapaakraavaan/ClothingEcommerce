using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductPrice;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductPrices
{
    public class IndexModel : PageModel
    {
        public SelectList Products;
        public SelectList Sizes;
        [TempData] public string Message { get; set; }
        public ProductPriceSearchModel SearchModel;
        public List<ProductPriceViewModel> ProductPrices;
        private readonly IProductApplication _productApplication;
        private readonly IProductPriceApplication _productPriceApplication;

        public IndexModel(IProductApplication productApplication, IProductPriceApplication productPriceApplication)
        {
            _productApplication = productApplication;
            _productPriceApplication = productPriceApplication;
        }

        public void OnGet(ProductPriceSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            Sizes = new SelectList(_productApplication.GetProductSizes(), "Id", "Size");
            ProductPrices = _productPriceApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProductPrice
            {
                Products = _productApplication.GetProducts(),
                Sizes = _productApplication.GetProductSizes()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProductPrice command)
        {
            var result = _productPriceApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var product = _productPriceApplication.GetDetails(id);
            product.Products = _productApplication.GetProducts();
            product.Sizes = _productApplication.GetProductSizes();
            return Partial("./Edit", product);
        }

        public JsonResult OnPostEdit(EditProductPrice command)
        {
            var result = _productPriceApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}