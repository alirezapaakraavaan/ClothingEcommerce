using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class ProfileModel : PageModel
    {
        public List<OrderViewModel> Orders;
        public List<AccountViewModel> Accounts;
        private readonly IAuthHelper _authHelper;
        private readonly IOrderApplication _orderApplication;
        private readonly IAccountApplication _accountApplication;

        public ProfileModel(IOrderApplication orderApplication, IAuthHelper authHelper,
            IAccountApplication accountApplication)
        {
            _orderApplication = orderApplication;
            _authHelper = authHelper;
            _accountApplication = accountApplication;
        }

        public void OnGet(OrderSearchModel searchModel, AccountSearchModel searchModelAccount)
        {
            var accountId = _authHelper.CurrentAccountId();
            Orders = _orderApplication.Search(searchModel).Where(x => x.AccountId == accountId).ToList();
            Accounts = _accountApplication.Search(searchModelAccount).Where(x => x.Id == accountId).ToList();
        }

        public IActionResult OnGetItems(long id)
        {
            var items = _orderApplication.GetItemsBy(id);
            return Partial("Items", items);
        }

        public IActionResult OnGetChangeAddress(long id)
        {
            var command = new ChangeAddress { Id = id };
            return Partial("./ChangeAddress", command);
        }

        public JsonResult OnPostChangeAddress(ChangeAddress command)
        {
            var result = _accountApplication.ChangeAddress(command);
            return new JsonResult(result);
        }
    }
}