using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_EcommerceQuery.Contract.Products;
using CommentManagement.Domain.CommentAgg;
using CommentManagement.Infrastructure.EfCore;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Application.Contracts;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.ProductPictureAgg;
using ShopManagement.Infrastructure.EFCore;

namespace _01_EcommerceQuery.Query
{
    public class WemenProductQuery : IProductQueryWemen
    {
        private readonly ShopContext _context;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;
        private readonly CommentContext _commentContext;

        public WemenProductQuery(ShopContext context, InventoryContext inventoryContext,
            DiscountContext discountContext, CommentContext commentContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
            _commentContext = commentContext;
        }

        public List<ProductQueryModel> GetProductsForWemen()
        {
            var inventory = _inventoryContext.Inventories
                .Where(x => x.IsInStock)
                .Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var products = _context.Products.Where(x => !x.IsRemoved && x.ProductCategoryId == 3)
                .Select(x => new ProductQueryModel
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

            return products.Where(x => x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetWemenMantos()
        {
            var inventory = _inventoryContext.Inventories
                .Where(x => x.IsInStock)
                .Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var products = _context.Products.Where(x => !x.IsRemoved && x.ProductCategoryId == 3)
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

            return products.Where(x => x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetWemenBoluz()
        {
            var inventory = _inventoryContext.Inventories
                .Where(x => x.IsInStock)
                .Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var products = _context.Products.Where(x => !x.IsRemoved && x.ProductCategoryId == 4)
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

            return products.Where(x => x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetWemenTshirt()
        {
            var inventory = _inventoryContext.Inventories
                .Where(x => x.IsInStock)
                .Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var products = _context.Products.Where(x => !x.IsRemoved && x.ProductCategoryId == 5)
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

            return products.Where(x => x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetWemenTrouser()
        {
            var inventory = _inventoryContext.Inventories
                .Where(x => x.IsInStock)
                .Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var products = _context.Products.Where(x => !x.IsRemoved && x.ProductCategoryId == 6)
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

            return products.Where(x => x.IsInStock).ToList();
        }

        public List<ProductQueryModel> GetWemenUnderwear()
        {
            var inventory = _inventoryContext.Inventories
                .Where(x => x.IsInStock)
                .Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var products = _context.Products.Where(x => !x.IsRemoved && x.ProductCategoryId == 7)
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

            return products.Where(x => x.IsInStock).ToList();
        }

        public List<ProductQueryModel> Search(string value)
        {
            var inventory = _inventoryContext.Inventories
                .Where(x => x.IsInStock)
                .Select(x => new {x.ProductId, x.UnitPrice}).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var query = _context.Products.Where(x => !x.IsRemoved).Select(x =>
                new ProductQueryModel
                {
                    Id = x.Id,
                    IsRemoved = x.IsRemoved,
                    Picture = x.Picture,
                    Description = x.Description,
                    Name = x.Name,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug
                }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Name.Contains(value) || x.Description.Contains(value));

            var products = query.OrderByDescending(x => x.Id).ToList();

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

            return products.Where(x => x.IsInStock).ToList();
        }

        public ProductQueryModel GetDetails(string slug, string size, string color)
        {
            var inventory = _inventoryContext.Inventories.Select(x =>
                    new InventoryViewModel
                    {
                        ProductId = x.ProductId,
                        UnitPrice = x.UnitPrice,
                        IsInStock = x.IsInStock,
                        Size = x.Size,
                        Color = x.Color
                    })
                .ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x =>
                    new {x.DiscountRate, x.ProductId}).ToList();

            var product = _context.Products
                .Include(x => x.ProductCategory)
                .Include(x => x.ProductPictures)
                .Where(x => !x.IsRemoved)
                .Select(x =>
                    new ProductQueryModel
                    {
                        Id = x.Id,
                        IsRemoved = x.IsRemoved,
                        Picture = x.Picture,
                        Description = x.Description,
                        Name = x.Name,
                        PictureAlt = x.PictureAlt,
                        PictureTitle = x.PictureTitle,
                        Slug = x.Slug,
                        Code = x.Code,
                        ProductCategorySlug = x.ProductCategory.Slug,
                        ShortDescription = x.ShortDescription,
                        MetaDescription = x.MetaDescription,
                        ProductPictures = MapProductPictures(x.ProductPictures),
                        Keywords = x.Keywords
                    }).FirstOrDefault(x => x.Slug == slug);

            if (product == null)
                return new ProductQueryModel();

            var productInventory = inventory.Where(x => x.ProductId == product.Id).ToList();
            var defaultProductInventory = new InventoryViewModel();
            if (string.IsNullOrWhiteSpace(size))
                defaultProductInventory = productInventory.FirstOrDefault();
            else
                defaultProductInventory = productInventory.FirstOrDefault(x => x.Size == size);

            if (defaultProductInventory != null)
            {
                product.IsInStock = defaultProductInventory.IsInStock;
                var price = defaultProductInventory.UnitPrice;
                var productSize = productInventory.Where(x => x.IsInStock).Select(x => x.Size).ToList();
                var productColor = productInventory.Where(x => x.IsInStock).Select(x => x.Color).ToList();
                product.Size = productSize;
                product.Color = productColor;
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

            product.Comments = _commentContext.Comments
                .Where(x => x.Type == CommentType.Product)
                .Where(x => x.OwnerRecordId == product.Id)
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Message = x.Message,
                    Name = x.Name,
                    CreationDate = x.CreationDate.ToFarsi()
                }).OrderByDescending(x => x.Id).ToList();

            return product;
        }

        public List<CartItem> CheckInventoryStatus(List<CartItem> cartItems)
        {
            var inventory = _inventoryContext.Inventories.ToList();

            foreach (var cartItem in cartItems.Where(cartItem =>
                inventory.Any(x => x.ProductId == cartItem.Id && x.IsInStock)))
            {
                var itemInventory = inventory.Find(x => x.ProductId == cartItem.Id && x.Size == cartItem.Size);
                cartItem.IsInStock = itemInventory.CalculateCurrentCount() >= cartItem.Count;
            }

            return cartItems;
        }

        private static List<ProductPictureQueryModel> MapProductPictures(IEnumerable<ProductPicture> productPictures)
        {
            return productPictures.Select(x => new ProductPictureQueryModel
            {
                IsRemoved = x.IsRemoved,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ProductId = x.ProductId
            }).Where(x => !x.IsRemoved).ToList();
        }
    }
}