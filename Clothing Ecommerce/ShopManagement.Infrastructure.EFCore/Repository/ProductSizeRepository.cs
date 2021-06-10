using System.Collections.Generic;
using System.Linq;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.ProductSize;
using ShopManagement.Domain.ProductSizeAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductSizeRepository : RepositoryBase<long, ProductSize>, IProductSizeRepository
    {
        private readonly ShopContext _context;

        public ProductSizeRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProductSize GetDetails(long id)
        {
            return _context.ProductSizes.Select(x => new EditProductSize
            {
                Id = x.Id,
                Size = x.Size,
                ProductId = x.ProductId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductSizeViewModel> Search(ProductSizeSearchModel searchModel)
        {
            var query = _context.ProductSizes.Include(x => x.Product).Select(x => new ProductSizeViewModel
            {
                Id = x.Id,
                Size = x.Size,
                ProductId = x.ProductId,
                Product = x.Product.Name
            });

            if (searchModel.ProductId != 0)
                query = query.Where(x => x.ProductId == searchModel.ProductId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}