using System.Collections.Generic;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.MainCategory;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.MainCategories
{
    public class IndexModel : PageModel
    {
        public MainCategorySearchModel SearchModel;
        public List<MainCategoryViewModel> MainCategories;
        private readonly IMainCategoryApplication _mainCategoryApplication;

        public IndexModel(IMainCategoryApplication mainCategoryApplication)
        {
            _mainCategoryApplication = mainCategoryApplication;
        }

        [NeedsPermissions(ShopPermissions.ListMainCategories)]
        public void OnGet(MainCategorySearchModel searchModel)
        {
            MainCategories = _mainCategoryApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateMainCategory());
        }

        [NeedsPermissions(ShopPermissions.CreateMainCategories)]
        public JsonResult OnPostCreate(CreateMainCategory command)
        {
            var result = _mainCategoryApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var mainCategory = _mainCategoryApplication.GetDetails(id);
            return Partial("./Edit", mainCategory);
        }

        [NeedsPermissions(ShopPermissions.EditMainCategories)]
        public JsonResult OnPostEdit(EditMainCategory command)
        {
            var result = _mainCategoryApplication.Edit(command);
            return new JsonResult(result);
        }

        [NeedsPermissions(ShopPermissions.RemoveMainCategories)]
        public IActionResult OnGetRemove(long id)
        {
            var mainCategory = _mainCategoryApplication.Remove(id);
            return RedirectToPage("./Index");
        }
    }
}