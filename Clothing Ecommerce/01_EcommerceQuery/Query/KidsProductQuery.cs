using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_EcommerceQuery.Contract.Products;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_EcommerceQuery.Query
{
    public class KidsProductQuery : IProductQueryKids
    {
        private readonly ShopContext _context;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;

        public KidsProductQuery(ShopContext context, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }

        public List<ProductQueryModel> GetProductsForKids()
        {
            var discounts = _discountContext.CustomerDiscounts.Where(x =>
                    x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new {x.DiscountRate, x.ProductId}).ToList();

            var inventory = _inventoryContext.Inventories.Select(x =>
                new {x.ProductId, x.UnitPrice}).ToList();

            var products = _context.Products.Include(x => x.ProductCategory)
                .Where(x => !x.IsRemoved && x.ProductCategoryId == 8)
                .Select(x => new ProductQueryModel
                {
                    Id = x.Id,
                    IsRemoved = x.IsRemoved,
                    Picture = x.Picture,
                    Name = x.Name,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug
                }).OrderByDescending(x=>x.Id).Take(6).ToList();

            foreach (var product in products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
                    var price = productInventory.UnitPrice;
                    product.Price = price.ToMoney();

                    var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discount != null)
                    {
                        int discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        product.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        product.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }
            return products;
        }

        public List<ProductQueryModel> GetGirlsProducts()
        {
            var discounts = _discountContext.CustomerDiscounts.Where(x =>
                    x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId }).ToList();

            var inventory = _inventoryContext.Inventories.Select(x =>
                new { x.ProductId, x.UnitPrice }).ToList();

            var products = _context.Products.Include(x => x.ProductCategory)
                .Where(x => !x.IsRemoved && x.ProductCategoryId == 9)
                .Select(x => new ProductQueryModel
                {
                    Id = x.Id,
                    IsRemoved = x.IsRemoved,
                    Picture = x.Picture,
                    Name = x.Name,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var product in products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
                    var price = productInventory.UnitPrice;
                    product.Price = price.ToMoney();

                    var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discount != null)
                    {
                        int discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        product.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        product.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }
            return products;
        }

        public List<ProductQueryModel> GetBoysProducts()
        {
            var discounts = _discountContext.CustomerDiscounts.Where(x =>
                    x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId }).ToList();

            var inventory = _inventoryContext.Inventories.Select(x =>
                new { x.ProductId, x.UnitPrice }).ToList();

            var products = _context.Products.Include(x => x.ProductCategory)
                .Where(x => !x.IsRemoved && x.ProductCategoryId == 8)
                .Select(x => new ProductQueryModel
                {
                    Id = x.Id,
                    IsRemoved = x.IsRemoved,
                    Picture = x.Picture,
                    Name = x.Name,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var product in products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
                    var price = productInventory.UnitPrice;
                    product.Price = price.ToMoney();

                    var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discount != null)
                    {
                        int discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        product.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        product.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }
            return products;
        }

        public List<ProductQueryModel> GetBabysProducts()
        {
            var discounts = _discountContext.CustomerDiscounts.Where(x =>
                    x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId }).ToList();

            var inventory = _inventoryContext.Inventories.Select(x =>
                new { x.ProductId, x.UnitPrice }).ToList();

            var products = _context.Products.Include(x => x.ProductCategory)
                .Where(x => !x.IsRemoved && x.ProductCategoryId == 10)
                .Select(x => new ProductQueryModel
                {
                    Id = x.Id,
                    IsRemoved = x.IsRemoved,
                    Picture = x.Picture,
                    Name = x.Name,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var product in products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
                    var price = productInventory.UnitPrice;
                    product.Price = price.ToMoney();

                    var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discount != null)
                    {
                        int discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        product.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        product.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }
            return products;
        }
    }
}