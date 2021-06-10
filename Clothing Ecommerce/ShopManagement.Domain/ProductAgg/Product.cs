using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductColorAgg;
using ShopManagement.Domain.ProductPictureAgg;
using ShopManagement.Domain.ProductPriceAgg;
using ShopManagement.Domain.ProductSizeAgg;

namespace ShopManagement.Domain.ProductAgg
{
    public class Product : EntityBase
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public double UnitPrice { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public bool IsRemoved { get; private set; }
        public bool IsInStock { get; private set; }
        public string Color { get; private set; }
        public string Size { get; private set; }
        public long ProductCategoryId { get; private set; }
        public ProductCategory ProductCategory { get; private set; }
        public List<ProductPicture> ProductPictures { get; private set; }
        public List<ProductSize> ProductSizes { get; private set; }
        public List<ProductColor> ProductColors { get; private set; }
        public List<ProductPrice> ProductPrices { get; private set; }

        public Product(string name, string code, double unitPrice, string shortDescription, string description,
            string picture, string pictureAlt, string pictureTitle, string slug, string keywords,
            string metaDescription, string color, string size, long productCategoryId)
        {
            Name = name;
            Code = code;
            UnitPrice = unitPrice;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Color = color;
            Size = size;
            ProductCategoryId = productCategoryId;
            IsRemoved = false;
            IsInStock = true;
        }

        public void Edit(string name, string code, double unitPrice, string shortDescription, string description,
            string picture, string pictureAlt, string pictureTitle, string slug, string keywords,
            string metaDescription, string color, string size, long productCategoryId)
        {
            Name = name;
            Code = code;
            UnitPrice = unitPrice;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Color = color;
            Size = size;
            ProductCategoryId = productCategoryId;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }

        public void InStock()
        {
            IsInStock = true;
        }

        public void NotInStock()
        {
            IsInStock = false;
        }
    }
}