using System.Collections.Generic;
using System.Linq;
using _01_EcommerceQuery.Contract.Slide;
using ShopManagement.Infrastructure.EFCore;

namespace _01_EcommerceQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly ShopContext _context;

        public SlideQuery(ShopContext context)
        {
            _context = context;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return _context.Slides.Where(x => !x.IsRemoved).Select(x => new SlideQueryModel
            {
                BtnText = x.BtnText,
                Hashtag = x.Hashtag,
                Link = x.Link,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Title = x.Title
            }).ToList();
        }
    }
}