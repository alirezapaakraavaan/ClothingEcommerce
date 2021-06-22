using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Products
{
    public class ProductQueryModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public List<string> Size { get; set; }
        public List<string> Color { get; set; }
        public string PriceWithDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsInStock { get; set; }
        public bool HasDiscount { get; set; }
        public string Code { get; set; }
        public string ShortDescription { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public string ProductCategorySlug { get; set; }
        public List<ProductPictureQueryModel> ProductPictures { get; set; }
    }
}