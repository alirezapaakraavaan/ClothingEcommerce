using System.Collections.Generic;
using System.Linq;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.ProductColor;
using ShopManagement.Domain.ProductColorAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductColorRepository : RepositoryBase<long, ProductColor>, IProductColorRepository
    {
        private readonly ShopContext _context;

        public ProductColorRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProductColor GetDetails(long id)
        {
            return _context.ProductColors.Select(x => new EditProductColor
            {
                Id = x.Id,
                Color = x.Color,
                ProductId = x.ProductId,
                ProductSizeId = x.ProductSizeId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductColorViewModel> Search(ProductColorSearchModel searchModel)
        {
            var query = _context.ProductColors.Include(x => x.Product).Select(x => new ProductColorViewModel
            {
                Id = x.Id,
                Color = x.Color,
                Size = x.ProductSize.Size,
                ProductId = x.ProductId,
                Product = x.Product.Name
            });

            if (searchModel.ProductId != 0)
                query = query.Where(x => x.ProductId == searchModel.ProductId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}