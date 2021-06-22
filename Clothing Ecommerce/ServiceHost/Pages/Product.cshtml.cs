using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Comment;

namespace ServiceHost.Pages
{
    public class ProductModel : PageModel
    {
        public ProductQueryModel Product;
        private readonly IProductQueryWemen _productQueryWemen;
        private readonly ICommentApplication _commentApplication;

        public ProductModel(IProductQueryWemen productQueryWemen, ICommentApplication commentApplication)
        {
            _productQueryWemen = productQueryWemen;
            _commentApplication = commentApplication;
        }

        public void OnGet(string id, string size, string color)
        {
            Product = _productQueryWemen.GetDetails(id, size, color);
        }

        public IActionResult OnPost(AddComment command, string productSlug)
        {
            var result = _commentApplication.Add(command);
            return RedirectToPage("/Product", new {Id = productSlug});
        }
    }
}