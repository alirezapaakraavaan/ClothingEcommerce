using System.Collections.Generic;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.MainCategory;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        public ProductCategorySearchModel SearchModel;
        public List<ProductCategoryViewModel> ProductCategory;
        public SelectList MainCategories;
        private readonly IProductCategoryApplication _productCategoryApplication;
        private readonly IMainCategoryApplication _mainCategoryApplication;

        public IndexModel(IProductCategoryApplication productCategoryApplication,
            IMainCategoryApplication mainCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
            _mainCategoryApplication = mainCategoryApplication;
        }

        [NeedsPermissions(ShopPermissions.ListProductCategories)]
        public void OnGet(ProductCategorySearchModel searchModel)
        {
            MainCategories = new SelectList(_mainCategoryApplication.GetMainCategories(), "Id",
                "Name");
            ProductCategory = _productCategoryApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProductCategory
            {
                MainCategories = _mainCategoryApplication.GetMainCategories()
            };
            return Partial("./Create", command);
        }

        [NeedsPermissions(ShopPermissions.CreateProductCategories)]

        public JsonResult OnPostCreate(CreateProductCategory command)
        {
            var result = _productCategoryApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _productCategoryApplication.GetDetails(id);
            productCategory.MainCategories = _mainCategoryApplication.GetMainCategories();
            return Partial("./Edit", productCategory);
        }

        [NeedsPermissions(ShopPermissions.EditProductCategories)]

        public JsonResult OnPostEdit(EditProductCategory command)
        {
            var result = _productCategoryApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var mainCategory = _productCategoryApplication.Remove(id);
            return RedirectToPage("./Index");
        }
    }
}