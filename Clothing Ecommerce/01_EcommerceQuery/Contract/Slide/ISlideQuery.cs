using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();
    }
}