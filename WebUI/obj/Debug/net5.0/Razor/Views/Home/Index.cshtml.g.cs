#pragma checksum "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76edc969da2ec2ca719d0c44b7771f9388f45ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Dogan\Example\Agackakan\WebUI\Views\_ViewImports.cshtml"
using Entities.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dogan\Example\Agackakan\WebUI\Views\_ViewImports.cshtml"
using Entities.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dogan\Example\Agackakan\WebUI\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76edc969da2ec2ca719d0c44b7771f9388f45ce8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380e35b3bf29d63ae33336d0dc36793e682a0f49", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCardDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Slider/slider1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Slider/slider2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Rol Y??netimi"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""hero-box-area"">
    <div class=""container"">
        <div class=""row "">
            <div class=""col-lg-12"">
                <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner rounded"">
                        <div class=""carousel-item active"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76edc969da2ec2ca719d0c44b7771f9388f45ce84924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                        <div class=\"carousel-item\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76edc969da2ec2ca719d0c44b7771f9388f45ce86151", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true"" style=""width: 35px !important; height: 35px !important;""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true"" style=""width: 35px !important; height: 35px !important;""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>

            </div>
        </div>
    </div>
</div>

<div class=""about-us-area"" style=""padding-top:120px"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""about-us-con");
            WriteLiteral(@"tent_6 text-center"">
                    <h2>Aga??kakan Hobi At??lyesi</h2>
                    <p>
                        When you start with a portrait and search for a pure form, a clear volume, through successive eliminations,
                        you arrive inevitably at the egg. Likewise, starting with the egg and following the same process in reverse,
                        one finishes with the portrait.
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>


<!-- Product Area Start -->
<div class=""product-wrapper section-space--ptb_120"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-4"">
                <div class=""section-title text-lg-left text-center mb-20"">
                    <h3 class=""section-title"">Son Eklenen ??r??nler</h3>
                </div>
            </div>
        </div>
        <div class=""tab-content mt-30"">
            <div class=""row"">
");
#nullable restore
#line 67 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-6 col-md-4 rounded\">\n        <div class=\"single-product-item text-center\">\n            <div class=\"products-images rounded\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 2931, "\"", 2977, 2);
            WriteAttributeValue("", 2938, "/products/productdetail/", 2938, 24, true);
#nullable restore
#line 72 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2962, item.ProductId, 2962, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-thumbnail rounded\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3038, "\"", 3055, 1);
#nullable restore
#line 73 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 3044, item.Image, 3044, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded\"");
            BeginWriteAttribute("alt", " alt=\"", 3072, "\"", 3088, 1);
#nullable restore
#line 73 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 3078, item.Name, 3078, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                </a>\n            </div>\n            <div class=\"product-content rounded\">\n                <h6 class=\"prodect-title\" style=\"min-height:66px\"><a href=\"product-details.html\">");
#nullable restore
#line 77 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\n                <div class=\"prodect-price\">\n");
#nullable restore
#line 79 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
                     if (item.Price1 != 0 && item.Price2 != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6 style=\"color:#E74C3C\">\n        <del> ");
#nullable restore
#line 82 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
         Write(item.Price1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??? </del>\n    </h6>\n                        <h5> ");
#nullable restore
#line 84 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
                        Write(item.Price2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??? </h5> ");
#nullable restore
#line 84 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
                                                  }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5> ");
#nullable restore
#line 87 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
                        Write(item.Price2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??? </h5>");
#nullable restore
#line 87 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>");
#nullable restore
#line 91 "D:\Dogan\Example\Agackakan\WebUI\Views\Home\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </div>
    <div class=""text-center"" style=""margin-top:120px"">
        <a href=""/products/products/"" class=""btn btn--lg btn--border_1 rounded"" style=""min-width:350px !important"">
            <i class=""fas fa-external-link-alt mr-3""></i>T??m??n?? G??r??nt??le
        </a>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductCardDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
