using System.Collections.Generic;
using System.Linq;
using _01_EcommerceQuery.Contract.ProductCategories;
using ShopManagement.Infrastructure.EFCore;

namespace _01_EcommerceQuery.Query
{
    public class WemenProductCategoryQuery : IProductCategoryQueryWemen
    {
        private readonly ShopContext _context;

        public WemenProductCategoryQuery(ShopContext context)
        {
            _context = context;
        }

        public List<ProductCategoryQueryModel> GetProductCategoriesForWemen()
        {
            return _context.ProductCategories.Where(x => !x.IsRemoved && x.MainCategoryId == 11).Select(x => new
                ProductCategoryQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug
                }).ToList();
        }
    }
}