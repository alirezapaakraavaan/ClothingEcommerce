using System.Linq;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Infrastructure.EfCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ForgotPasswordModel : PageModel
    {
        private readonly IAccountRepository _accountRepository;
        private readonly AccountContext _context;

        public ForgotPasswordModel(IAccountRepository accountRepository, AccountContext context)
        {
            _accountRepository = accountRepository;
            _context = context;
        }

        public void OnGet()
        {
        }

        /*public IActionResult OnPostForgotPassword(string number)
        {
            var mobileNumber = _accountRepository.GetUserMobileNumber(number);
            if (mobileNumber.Mobile == number)
            {

            }
        }*/
    }
}