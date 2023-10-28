#pragma checksum "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a48280b14ae9a8411854ab549863d405edbdd8fc79c82f76f2349f04a65ceaa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slider.Pages_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slider/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slider
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a48280b14ae9a8411854ab549863d405edbdd8fc79c82f76f2349f04a65ceaa7", @"/Pages/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"84e67cc624686472d6ee628a8fd93a67c79f2978653a37fe57c229fa14270597", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_Lampshade1Query.Contracts.Slide.SlideQueryModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-slider-area section-space"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""hero-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                        ""slidesToShow"": 1,
                        ""slidesToScroll"": 1,
                        ""arrows"": true,
                        ""dots"": true,
                        ""autoplay"": true,
                        ""autoplaySpeed"": 5000,
                        ""speed"": 1000,
                        ""fade"": true,
                        ""infinite"": true,
                        ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                        ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                    }' data-slick-responsive='[
                        {""breakpoint"":1501, ""settings"": {""slidesToShow"": 1} },
                        {""breakpoint""");
            WriteLiteral(@":1199, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":991, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":767, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":575, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                    ]'>
");
#nullable restore
#line 28 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                         foreach (var slide in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-slider-item\">\r\n                                <div class=\"hero-slider-item-wrapper\">\r\n                                    <div class=\"container\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1879, "\"", 1899, 1);
#nullable restore
#line 33 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 1885, slide.Picture, 1885, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1900, "\"", 1923, 1);
#nullable restore
#line 33 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 1906, slide.PictureAlt, 1906, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1924, "\"", 1951, 1);
#nullable restore
#line 33 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 1932, slide.PictureTitle, 1932, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""hero-slider-content hero-slider-content--left-space"">
                                                    <p class=""slider-title slider-title--big-light"">");
#nullable restore
#line 37 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                                                               Write(slide.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n                                                    <p class=\"slider-title slider-title--big-bold\">");
#nullable restore
#line 38 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                                                              Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--small\">\r\n                                                        ");
#nullable restore
#line 40 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                   Write(slide.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </p>\r\n                                                    <a class=\"hero-slider-button\"");
            BeginWriteAttribute("href", " href=\"", 2744, "\"", 2762, 1);
#nullable restore
#line 42 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 2751, slide.Link, 2751, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 43 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                   Write(slide.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""ion-ios-plus-empty""></i>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 51 "D:\PROGRAMING\C#\Core\Lamp Shade 1\Code\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_Lampshade1Query.Contracts.Slide.SlideQueryModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
