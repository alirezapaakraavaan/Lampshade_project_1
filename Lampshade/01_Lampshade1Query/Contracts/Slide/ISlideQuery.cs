using System.Collections.Generic;

namespace _01_Lampshade1Query.Contracts.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();
    }
}