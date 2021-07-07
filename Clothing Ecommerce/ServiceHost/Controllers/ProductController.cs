using _01_EcommerceQuery.Contract.Products;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductQueryWemen _productQueryWemen;

        public ProductController(IProductQueryWemen productQueryWemen)
        {
            _productQueryWemen = productQueryWemen;
        }

        [HttpGet("GetWemenProductPriceBy/{slug}/{size}/{color}")]
        public IActionResult GetWemenProductPriceBy(string slug, string size, string color)
        {
            return new JsonResult(_productQueryWemen.GetDetails(slug, size, color));
        }
    }
}