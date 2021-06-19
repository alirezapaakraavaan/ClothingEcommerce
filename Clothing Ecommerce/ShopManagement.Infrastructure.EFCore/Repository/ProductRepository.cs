using System.Collections.Generic;
using System.Linq;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductRepository : RepositoryBase<long, Product>, IProductRepository
    {
        private readonly ShopContext _context;

        public ProductRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public Product GetProductWithCategory(long id)
        {
            return _context.Products.Include(x => x.ProductCategory).FirstOrDefault(x => x.Id == id);
        }

        public EditProduct GetDetails(long id)
        {
            return _context.Products.Select(x => new EditProduct
            {
                Id = x.Id,
                Code = x.Code,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Name = x.Name,
                Slug = x.Slug,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
                ProductCategoryId = x.ProductCategoryId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            var query = _context.Products.Include(x => x.ProductCategory)
                .Where(x => !x.IsRemoved).Select(x => new ProductViewModel
                {
                    ProductCategoryId = x.ProductCategoryId,
                    Code = x.Code,
                    Id = x.Id,
                    Name = x.Name,
                    Picture = x.Picture,
                    ProductCategoryName = x.ProductCategory.Name,
                    IsRemoved = x.IsRemoved
                });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.ProductCategoryName))
                query = query.Where(x => x.ProductCategoryName.Contains(searchModel.ProductCategoryName));

            if (!string.IsNullOrWhiteSpace(searchModel.Code))
                query = query.Where(x => x.Code.Contains(searchModel.Code));

            if (searchModel.ProductCategoryId != 0)
                query = query.Where(x => x.ProductCategoryId == searchModel.ProductCategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public List<ProductViewModel> GetProducts()
        {
            return _context.Products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}