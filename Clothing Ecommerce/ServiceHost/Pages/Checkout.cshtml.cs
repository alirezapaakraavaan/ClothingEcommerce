using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Application.ZarinPal;
using _01_EcommerceQuery.Contract;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    [Authorize]
    public class CheckoutModel : PageModel
    {
        public Cart Cart;
        public const string CookieName = "cart-items";
        private readonly ICartCalculatorService _cartCalculatorService;
        private readonly ICartService _cartService;
        private readonly IProductQueryWemen _productQueryWemen;
        private readonly IOrderApplication _orderApplication;
        private readonly IZarinPalFactory _zarinPalFactory;
        private readonly IAuthHelper _authHelper;

        public CheckoutModel(ICartCalculatorService cartCalculatorService, ICartService cartService,
            IProductQueryWemen productQueryWemen, IOrderApplication orderApplication, IZarinPalFactory zarinPalFactory,
            IAuthHelper authHelper)
        {
            Cart = new Cart();
            _cartCalculatorService = cartCalculatorService;
            _cartService = cartService;
            _productQueryWemen = productQueryWemen;
            _orderApplication = orderApplication;
            _zarinPalFactory = zarinPalFactory;
            _authHelper = authHelper;
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);

            foreach (var item in cartItems)
                item.CalculateTotalItemPrice();

            Cart = _cartCalculatorService.ComputeCart(cartItems);
            _cartService.Set(Cart);
        }

        public IActionResult OnPostPay(int paymentMethod)
        {
            var cart = _cartService.Get();
            cart.SetPaymentMethod(paymentMethod);
            var result = _productQueryWemen.CheckInventoryStatus(cart.CartItems);

            if (result.Any(x => !x.IsInStock))
                return RedirectToPage("/Cart");

            var orderId = _orderApplication.PlaceOrder(cart);
            if (paymentMethod == 1)
            {
                var paymentResponse = _zarinPalFactory
                    .CreatePaymentRequest(cart.PayAmount.ToString(CultureInfo.InvariantCulture), "", "",
                        "خرید از درگاه", orderId);

                return Redirect(
                    $"https://{_zarinPalFactory.Prefix}.zarinpal.com/pg/StartPay/{paymentResponse.Authority}");
            }

            var paymentResult = new PaymentResult();
            return RedirectToPage("/PaymentResult",
                paymentResult.Succeeded(
                    "سفارش شما با موفقیت ثبت شد. پس از تماس کارشناسان ما و پرداخت وجه سفارش ارسال خواهد شد.",
                    null));
        }

        public IActionResult OnGetCallBack([FromQuery] string authority, [FromQuery] string status,
            [FromQuery] long oId)
        {
            var orderAmount = _orderApplication.GetAmountBy(oId);
            var verificationResponse =
                _zarinPalFactory.CreateVerificationRequest(authority,
                    orderAmount.ToString(CultureInfo.InvariantCulture));

            var result = new PaymentResult();
            if (status == "OK" && verificationResponse.Status >= 100)
            {
                var issueTrackingNo = _orderApplication.PaymentSucceeded(oId, verificationResponse.RefID);
                Response.Cookies.Delete(CookieName);
                result = result.Succeeded("پرداخت با موفقیت انجام شد", issueTrackingNo);
                return RedirectToPage("/PaymentResult", result);
            }

            result = result.Failed(
                "پرداخت با خطا مواجه شد در صورت کسر وجه از حساب شما مبلغ کسری تا 24 ساعت آینده به حسابتان بازگردانده میشود");
            return RedirectToPage("/PaymentResult", result);
        }
    }
}