#pragma checksum "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\Shared\Components\MenProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eecc56b562977ab58da2c8b4d8de1ec96a1b03ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.MenProduct.Pages_Shared_Components_MenProduct_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/MenProduct/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.MenProduct
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eecc56b562977ab58da2c8b4d8de1ec96a1b03ff", @"/Pages/Shared/Components/MenProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_MenProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_EcommerceQuery.Contract.Products.ProductQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/images/banners/men.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"banner-with-product-area\">\r\n    <div class=\"container wide\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 order-2 order-lg-1\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 7 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\Shared\Components\MenProduct\Default.cshtml"
                     foreach (var product in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-12 col-lg-4 col-md-6 col-sm-6 mb-45"">
                            <div class=""single-product"">
                                <div class=""single-product__image"">
                                    <a class=""image-wrap"" href=""shop-product-basic.html"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 677, "\"", 699, 1);
#nullable restore
#line 13 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\Shared\Components\MenProduct\Default.cshtml"
WriteAttributeValue("", 683, product.Picture, 683, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 718, "\"", 743, 1);
#nullable restore
#line 13 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\Shared\Components\MenProduct\Default.cshtml"
WriteAttributeValue("", 724, product.PictureAlt, 724, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 744, "\"", 773, 1);
#nullable restore
#line 13 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\Shared\Components\MenProduct\Default.cshtml"
WriteAttributeValue("", 752, product.PictureTitle, 752, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""height: 300px"">
                                    </a>

                                    <div class=""single-product__floating-badges"">
                                    </div>
                                </div>

                                <div class=""single-product__content"">
                                    <div class=""title"">
                                        <h3> <a href=""shop-product-basic.html"">");
#nullable restore
#line 22 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\Shared\Components\MenProduct\Default.cshtml"
                                                                          Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                                        <a href=""#"">Add to cart</a>
                                    </div>
                                    <div class=""price"">
                                        <span class=""main-price discounted"">");
#nullable restore
#line 26 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\Shared\Components\MenProduct\Default.cshtml"
                                                                       Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"discounted-price\">$100.00</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 32 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\Shared\Components\MenProduct\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

            <div class=""col-lg-4 order-1 order-lg-2 mb-md-50 mb-sm-50"">
                <div class=""product-side-banner"">
                    <a href=""shop-left-sidebar.html"" class=""mb-40"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eecc56b562977ab58da2c8b4d8de1ec96a1b03ff8502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </a>\r\n                    <a href=\"shop-left-sidebar.html\" class=\"product-side-banner--link\">#مردانه</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_EcommerceQuery.Contract.Products.ProductQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591