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
    public class MenProductQuery : IProductQueryMen
    {
        private readonly ShopContext _context;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;

        public MenProductQuery(ShopContext context, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }

        public List<ProductQueryModel> GetProductsForMen()
        {
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var inventory = _inventoryContext.Inventories.Where(x=>x.IsInStock).Select(x =>
                new {x.ProductId, x.UnitPrice}).ToList();

            var products = _context.Products.Include(x => x.ProductCategory).Where(x =>
                !x.IsRemoved && x.ProductCategoryId == 11).Select(x => new ProductQueryModel
            {
                Id = x.Id,
                IsRemoved = x.IsRemoved,
                Picture = x.Picture,
                Name = x.Name,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug
            }).OrderByDescending(x => x.Id).Take(6).ToList();

            foreach (var product in products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
                    var price = productInventory.UnitPrice;
                    product.Price = price.ToMoney();
                    product.IsInStock = true;

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

            return products.Where(x=>x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetMenTshirt()
        {
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var inventory = _inventoryContext.Inventories.Where(x=>x.IsInStock).Select(x =>
                new {x.ProductId, x.UnitPrice}).ToList();

            var products = _context.Products.Include(x => x.ProductCategory).Where(x =>
                !x.IsRemoved && x.ProductCategoryId == 11).Select(x => new ProductQueryModel
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
                    product.IsInStock = true;

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

            return products.Where(x=>x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetMenShirt()
        {
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var inventory = _inventoryContext.Inventories.
                Where(x=>x.IsInStock).Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var products = _context.Products.Include(x => x.ProductCategory).Where(x =>
                !x.IsRemoved && x.ProductCategoryId == 12).Select(x => new ProductQueryModel
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
                    product.IsInStock = true;

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

            return products.Where(x=>x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetMenTrouser()
        {
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var inventory = _inventoryContext.Inventories
                .Where(x => x.IsInStock).Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var products = _context.Products
                .Include(x => x.ProductCategory)
                .Where(x => !x.IsRemoved && x.ProductCategoryId == 13).Select(x => new ProductQueryModel
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
                    product.IsInStock = true;

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

            return products.Where(x=>x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetMenUnderwear()
        {
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var inventory = _inventoryContext.Inventories.Where(x=>x.IsInStock).Select(x =>
                new {x.ProductId, x.UnitPrice}).ToList();

            var products = _context.Products.Include(x => x.ProductCategory).Where(x =>
                !x.IsRemoved && x.ProductCategoryId == 14).Select(x => new ProductQueryModel
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
                    product.IsInStock = true;

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

            return products.Where(x=>x.IsInStock).ToList();
        }
    }
}