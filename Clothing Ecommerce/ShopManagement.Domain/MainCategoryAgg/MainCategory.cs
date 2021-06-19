using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Domain.MainCategoryAgg
{
    public class MainCategory : EntityBase
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string Slug { get; private set; }
        public bool IsRemoved { get; private set; }
        public List<ProductCategory> ProductCategories { get; private set; }

        public MainCategory()
        {
            ProductCategories = new List<ProductCategory>();
        }

        public MainCategory(string name, string picture, string pictureAlt, string pictureTitle, string keywords,
            string metaDescription, string slug)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            IsRemoved = false;
        }

        public void Edit(string name, string picture, string pictureAlt, string pictureTitle, string keywords,
            string metaDescription, string slug)
        {
            Name = name;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
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