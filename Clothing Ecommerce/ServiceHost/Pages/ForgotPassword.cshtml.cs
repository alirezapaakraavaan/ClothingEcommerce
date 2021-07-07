using _0_Framework.Application.Email;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ForgotPasswordModel : PageModel
    {
        private readonly IEmailService _emailService;

        public ForgotPasswordModel(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void OnGet()
        {
            _emailService.SendEmail("Salam", "Salam bar shoma", "alirezapakravan111@gmail.com");
        }
    }
}