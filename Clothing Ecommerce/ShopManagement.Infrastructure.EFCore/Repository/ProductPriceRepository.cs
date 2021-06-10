using System.Collections.Generic;
using System.Linq;
using _0_Framework.Infrastructure;
using ShopManagement.Application.Contracts.ProductPrice;
using ShopManagement.Domain.ProductPriceAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductPriceRepository : RepositoryBase<long, ProductPrice>, IProductPriceRepository
    {
        private readonly ShopContext _context;

        public ProductPriceRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProductPrice GetDetails(long id)
        {
            return _context.ProductPrices.Select(x => new EditProductPrice
            {
                Id = x.Id,
                Price = x.Price,
                ProductId = x.ProductId,
                ProductSizeId = x.ProductSizeId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductPriceViewModel> Search(ProductPriceSearchModel searchModel)
        {
            var query = _context.ProductPrices.Select(x => new ProductPriceViewModel
            {
                Id = x.Id,
                Product = x.Product.Name,
                ProductId = x.ProductId,
                Price = x.Price,
                Size = x.ProductSize.Size
            });

            if (searchModel.ProductId != 0)
                query = query.Where(x => x.ProductId == searchModel.ProductId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}