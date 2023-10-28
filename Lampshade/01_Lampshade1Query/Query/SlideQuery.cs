using System.Collections.Generic;
using System.Linq;
using _01_Lampshade1Query.Contracts.Slide;
using ShopManagement.Infrastructure.EFCore;

namespace _01_Lampshade1Query.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly ShopContext _shopContext;

        public SlideQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return _shopContext.Slides.Where(x => x.IsRemoved == false).Select(x => new SlideQueryModel
            {
                Picture = x.Picture,
                BtnText = x.BtnText,
                Heading = x.Heading,
                Title = x.Title,
                Text = x.Text,
                Link = x.Link,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle
            }).ToList();
        }
    }
}