#pragma checksum "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ecfec288c69b8645d75d25f13c2414040ceb20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_MenProductsUnderwear), @"mvc.1.0.razor-page", @"/Pages/MenProductsUnderwear.cshtml")]
namespace ServiceHost.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ecfec288c69b8645d75d25f13c2414040ceb20", @"/Pages/MenProductsUnderwear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MenProductsUnderwear : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./MenProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
  
    ViewData["Title"] = "لباس زیر مردانه";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-area breadcrumb-bg-2 pt-50 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1 class=""breadcrumb-title"">فروشگاه</h1>
                <ul class=""breadcrumb-list"">
                    <li class=""breadcrumb-list__item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ecfec288c69b8645d75d25f13c2414040ceb204144", async() => {
                WriteLiteral("خانه");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-list__item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ecfec288c69b8645d75d25f13c2414040ceb205356", async() => {
                WriteLiteral("گروه محصولات");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-list__item breadcrumb-list__item--active"">لباس زیر مردانه</li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div class=""shop-page-header"">
    <div class=""container wide"">
        <div class=""row align-items-center"">
            <div class=""col-12 col-lg-7 col-md-10 d-none d-md-block"">
                <div class=""filter-title filter-title--type-two"">
                    <ul class=""product-filter-menu"">
                        <li class=""active"" data-filter=""*"">همه</li>
                    </ul>
                </div>
            </div>
            <div class=""col-12 col-lg-5 col-md-2"">
                <div class=""filter-icons"">
                    <div class=""single-icon grid-icons"">
                        <a data-target=""five-column"" class=""active"" href=""javascript:void(0)"">
                            <i class=""ti-layout-grid4-alt""></i>
                        </a>
                        <a data-target=""f");
            WriteLiteral(@"our-column"" href=""javascript:void(0)""><i class=""ti-layout-grid3-alt""></i></a>
                        <a data-target=""three-column"" href=""javascript:void(0)""><i class=""ti-layout-grid2-alt""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""shop-page-content mt-100 mb-100"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12 order-1 order-lg-2 mb-md-80 mb-sm-80"">
                <div class=""row product-isotope shop-product-wrap five-column"">
");
#nullable restore
#line 52 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                     foreach (var product in Model.menUnderwear)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-12 col-lg-4 col-md-6 col-sm-6 mb-45"">
                            <div class=""single-product"">
                                <div class=""single-product__image"">
                                    <a class=""image-wrap"" href=""shop-product-basic.html"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 2592, "\"", 2614, 1);
#nullable restore
#line 58 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
WriteAttributeValue("", 2598, product.Picture, 2598, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 2633, "\"", 2658, 1);
#nullable restore
#line 58 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
WriteAttributeValue("", 2639, product.PictureAlt, 2639, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2659, "\"", 2688, 1);
#nullable restore
#line 58 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
WriteAttributeValue("", 2667, product.PictureTitle, 2667, 21, false);

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
#line 65 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                                                                          Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                        <a href=\"#\">اضافه به سبد خرید</a>\r\n                                    </div>\r\n                                    <div class=\"price\">\r\n");
#nullable restore
#line 69 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                                         if (product.HasDiscount)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"main-price discounted\">");
#nullable restore
#line 71 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                                                                           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" نومان</span><br />\r\n                                            <span class=\"discounted-price\" style=\"color: red\">");
#nullable restore
#line 72 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                                                                                         Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 73 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"main-price\">");
#nullable restore
#line 76 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                                                                Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" نومان</span>\r\n");
#nullable restore
#line 77 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 82 "D:\PROGRAMING\C#\Core\Clothing Ecommerce\Clothing Ecommerce\ServiceHost\Pages\MenProductsUnderwear.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.MenProductsUnderwearModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.MenProductsUnderwearModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.MenProductsUnderwearModel>)PageContext?.ViewData;
        public ServiceHost.Pages.MenProductsUnderwearModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
