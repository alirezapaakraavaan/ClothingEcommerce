using System;
using System.Collections.Generic;
using System.Linq;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class CartModel : PageModel
    {
        public List<CartItem> CartItems;
        public const string CookieName = "cart-items";
        private readonly IProductQueryWemen _productQueryWemen;

        public CartModel(IProductQueryWemen productQueryWemen)
        {
            CartItems = new List<CartItem>();
            _productQueryWemen = productQueryWemen;
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);

            foreach (var item in cartItems)
                item.CalculateTotalItemPrice();

            CartItems = _productQueryWemen.CheckInventoryStatus(cartItems);
        }

        public IActionResult OnGetRemoveFromCart(long id)
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            Response.Cookies.Delete(CookieName);
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            var itemToRemove = cartItems.FirstOrDefault(x => x.Id == id);
            cartItems.Remove(itemToRemove);
            var options = new CookieOptions {Expires = DateTime.Now.AddDays(2)};
            Response.Cookies.Append(CookieName, serializer.Serialize(cartItems), options);
            return RedirectToPage("/Cart");
        }

        public IActionResult OnGetGoToCheckOut()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);

            foreach (var item in cartItems)
                item.CalculateTotalItemPrice();

            CartItems = _productQueryWemen.CheckInventoryStatus(cartItems);

            if (CartItems.Any(x => !x.IsInStock))
                return RedirectToPage("/Cart");

            return RedirectToPage("/Checkout");
        }
    }
}