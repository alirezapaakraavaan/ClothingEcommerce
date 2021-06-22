using System.Collections.Generic;
using System.Linq;
using _01_EcommerceQuery.Contract.ProductCategories;
using InventoryManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_EcommerceQuery.Query
{
    public class MenProductCategoryQuery : IProductCategoryQueryMen
    {
        private readonly ShopContext _context;
        private readonly InventoryContext _inventoryContext;

        public MenProductCategoryQuery(ShopContext context, InventoryContext inventoryContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
        }

        public List<ProductCategoryQueryModel> GetProductCategoriesForMen()
        {
            var productInventory = _inventoryContext.Inventories.Where(x => x.IsInStock).ToList();
            return _context.ProductCategories.Where(x => !x.IsRemoved && x.MainCategoryId == 1)
                .Select(x => new ProductCategoryQueryModel
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