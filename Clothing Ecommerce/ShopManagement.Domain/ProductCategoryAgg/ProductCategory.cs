using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Domain.MainCategoryAgg;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public class ProductCategory : EntityBase
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public bool IsRemoved { get; private set; }
        public long MainCategoryId { get; private set; }
        public MainCategory MainCategory { get; private set; }
        public List<Product> Products { get; private set; }

        public ProductCategory(string name, string picture, string pictureAlt, string pictureTitle, string slug,
            string keywords, string metaDescription, long mainCategoryId)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            MainCategoryId = mainCategoryId;
            IsRemoved = false;
        }

        public void Edit(string name, string picture, string pictureAlt, string pictureTitle, string slug,
            string keywords, string metaDescription, long mainCategoryId)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            MainCategoryId = mainCategoryId;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}