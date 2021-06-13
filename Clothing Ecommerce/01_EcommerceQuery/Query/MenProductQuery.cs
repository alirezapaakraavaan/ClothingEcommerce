using System.Collections.Generic;
using System.Linq;
using _01_EcommerceQuery.Contract.Products;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_EcommerceQuery.Query
{
    public class MenProductQuery : IProductQueryMen
    {
        private readonly ShopContext _context;

        public MenProductQuery(ShopContext context)
        {
            _context = context;
        }

        public List<ProductQueryModel> GetProductsForMen()
        {
            return _context.Products.Include(x => x.ProductCategory).Where(x => x.IsInStock &&
                !x.IsRemoved && x.ProductCategoryId == 11).Select(x => new ProductQueryModel
            {
                IsRemoved = x.IsRemoved,
                Picture = x.Picture,
                IsInStock = x.IsInStock,
                Name = x.Name,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug,
                Price = x.UnitPrice
            }).ToList();
        }
    }
}