#pragma checksum "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ffa9830c32f96af3652e1218407c23f9fcf061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductDetail), @"mvc.1.0.view", @"/Views/Products/ProductDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ffa9830c32f96af3652e1218407c23f9fcf061", @"/Views/Products/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380e35b3bf29d63ae33336d0dc36793e682a0f49", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/client/lightBox/css/lightbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/client/lightBox/js/lightbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
  
    ViewData["Title"] = "";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66ffa9830c32f96af3652e1218407c23f9fcf0614670", async() => {
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
                WriteLiteral("\r\n<style>\r\n    .lb-details {\r\n        display: none;\r\n    }\r\n</style>\r\n");
            }
            );
            WriteLiteral(@"<hr />
<!-- breadcrumb-area start -->
<div class=""breadcrumb-area"" style=""background-color:#ffffff !important;padding-top: 5px;padding-bottom: 5px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row breadcrumb_box  align-items-center"">
                    <div class=""col-lg-8 col-md-8 col-sm-8 text-center text-sm-left"">
                        <h3 class=""breadcrumb-title"">");
#nullable restore
#line 22 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                Write(Model.ProductModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    </div>
                    <div class=""col-lg-4  col-md-4 col-sm-4"">
                        <!-- breadcrumb-list start -->
                        <ul class=""breadcrumb-list text-center text-sm-right"">
                            <li class=""breadcrumb-item""><a href=""/"">Anasayfa</a></li>
                            <li class=""breadcrumb-item active"">");
#nullable restore
#line 28 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                          Write(Model.CategoryModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                        <!-- breadcrumb-list end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- breadcrumb-area end -->
<hr />






<div id=""main-wrapper"">
    <div class=""site-wrapper-reveal"">

        <div class=""single-product-wrap section-space--pt_60 border-bottom"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-9 col-md-6 col-sm-12 col-xs-12"">

                        <div class=""product-details-left"">
                            <div class=""product-details-images-2 text-center"">
");
#nullable restore
#line 55 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                 foreach (var item in Model.ProductImagesModel)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"example-image-link rounded\"");
            BeginWriteAttribute("href", " href=\"", 2031, "\"", 2053, 1);
#nullable restore
#line 57 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 2038, item.ImagePath, 2038, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\" data-lightbox=\"example-1\">\r\n                                        <img class=\"example-image rounded\"");
            BeginWriteAttribute("src", " src=\"", 2176, "\"", 2197, 1);
#nullable restore
#line 58 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 2182, item.ImagePath, 2182, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%\" />\r\n                                    </a>\r\n");
#nullable restore
#line 60 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"product-details-thumbs-2 text-center\">\r\n");
#nullable restore
#line 63 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                 foreach (var item2 in Model.ProductImagesModel)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img class=\"example-image rounded\" style=\"height:100px; width:100px\"");
            BeginWriteAttribute("src", " src=\"", 2637, "\"", 2659, 1);
#nullable restore
#line 65 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 2643, item2.ImagePath, 2643, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 66 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div> 
                    </div>
                    <div class=""col-lg-3 col-md-6 col-sm-12 col-xs-12"">
                        <div class=""product-details-content"">

                            <h4 class=""font-weight--reguler mb-10"">");
#nullable restore
#line 73 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                              Write(Model.ProductModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <div class=\"prodect-price\">\r\n");
#nullable restore
#line 75 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                 if (Model.ProductModel.Price1 != 0 && Model.ProductModel.Price2 != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h5 style=\"color:#E74C3C\"><del> ");
#nullable restore
#line 77 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                               Write(Model.ProductModel.Price1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </del></h5>\r\n                                    <h2> ");
#nullable restore
#line 78 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                    Write(Model.ProductModel.Price2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </h2>\r\n");
#nullable restore
#line 79 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h2> ");
#nullable restore
#line 82 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                    Write(Model.ProductModel.Price2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </h2>\r\n");
#nullable restore
#line 83 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n\r\n                            <div class=\"mt-30 \">\r\n                                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 3776, "\"", 3948, 13);
            WriteAttributeValue("", 3783, "https://api.whatsapp.com/send?phone=905376673492&text=Merhaba", 3783, 61, true);
            WriteAttributeValue(" ", 3844, "\'", 3845, 2, true);
#nullable restore
#line 88 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 3846, Model.ProductModel.ProductId, 3846, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3875, "\'", 3875, 1, true);
            WriteAttributeValue(" ", 3876, "numaralı", 3877, 9, true);
            WriteAttributeValue(" ", 3885, "\'", 3886, 2, true);
#nullable restore
#line 88 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 3887, Model.ProductModel.Name, 3887, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3911, "\'", 3911, 1, true);
            WriteAttributeValue(" ", 3912, "isimli", 3913, 7, true);
            WriteAttributeValue(" ", 3919, "ürünü", 3920, 6, true);
            WriteAttributeValue(" ", 3925, "satın", 3926, 6, true);
            WriteAttributeValue(" ", 3931, "almak", 3932, 6, true);
            WriteAttributeValue(" ", 3937, "istiyorum.", 3938, 11, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn--lg font-weight--reguler text-white rounded text-right"" style="" background: #25d366;"">
                                    <i class=""fab fa-whatsapp mr-3 fa-2x""></i>Satın Al
                                </a>
                            </div>

                            <div class=""product_meta mt-30"">
                                <div class=""sku_wrapper item_meta"">
                                    <span class=""label""> Barkod : </span>
                                    <span class=""sku"">");
#nullable restore
#line 96 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                 Write(Model.ProductModel.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"posted_in item_meta\">\r\n                                    <span class=\"label\">Kategori: </span><a");
            BeginWriteAttribute("href", " href=\"", 4693, "\"", 4749, 2);
            WriteAttributeValue("", 4700, "/products/products/", 4700, 19, true);
#nullable restore
#line 99 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 4719, Model.ProductModel.CategoryId, 4719, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 99 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                                                                                                Write(Model.CategoryModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <hr />
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""product_details_tab_content tab-content mt-30"">
                            <!-- Start Single Content -->
                            <div class=""product_tab_content tab-pane active"" id=""description"" role=""tabpanel"">
                                <div class=""product_description_wrap"">
                                    <div class=""product-details-wrap"">
                                        <div class=""row align-items-center"">
                                            <div class=""col-lg-12 order-md-1 order-2 mb-5"">
                                                <div class=""details mt-30"">
                                                    <h3 class=""mb-10"">Açıklama</h3>
                      ");
            WriteLiteral("                              <p>");
#nullable restore
#line 118 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                  Write(Model.ProductModel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""related-products section-space--ptb_90"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""section-title text-left"">
                                <h3>Benzer Ürünler</h3>
                            </div>
                        </div>
                    </div>
                    <div class=""row product-slider-active"">
");
#nullable restore
#line 138 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                         foreach (var item in Model.RelatedProducts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-12"">
                                <!-- Single Product Item Start -->
                                <div class=""single-product-item text-center"">
                                    <div class=""products-images"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 7077, "\"", 7123, 2);
            WriteAttributeValue("", 7084, "/products/productdetail/", 7084, 24, true);
#nullable restore
#line 144 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 7108, item.ProductId, 7108, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-thumbnail\" style=\"text-align: -webkit-center;\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 7237, "\"", 7254, 1);
#nullable restore
#line 145 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 7243, item.Image, 7243, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""height:300px !important; width:300px !important;"" class=""img-fluid"" alt=""Product Images"">
                                        </a>
                                    </div>
                                    <div class=""product-content"">
                                        <h6 class=""prodect-title""><a href=""product-details.html"">");
#nullable restore
#line 149 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                        <div class=\"prodect-price\">\r\n");
#nullable restore
#line 151 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                             if (item.Price1 != 0 && item.Price2 != 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <h6 style=\"color:#E74C3C\"><del> ");
#nullable restore
#line 153 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                                           Write(item.Price1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </del></h6>\r\n                                                <h5> ");
#nullable restore
#line 154 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                Write(item.Price2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </h5>\r\n");
#nullable restore
#line 155 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <h5> ");
#nullable restore
#line 158 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                                                Write(item.Price2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </h5>\r\n");
#nullable restore
#line 159 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div><!-- Single Product Item End -->\r\n                            </div>\r\n");
#nullable restore
#line 165 "D:\Dogan\Example\Agackakan\WebUI\Views\Products\ProductDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("js", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ffa9830c32f96af3652e1218407c23f9fcf06123474", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591