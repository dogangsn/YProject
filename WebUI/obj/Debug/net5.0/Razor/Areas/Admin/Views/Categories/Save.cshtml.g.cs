#pragma checksum "D:\Dogan\Example\Agackakan\WebUI\Areas\Admin\Views\Categories\Save.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46df7605b5587892b33cac34e40aa1278d0bfb9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Save), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Save.cshtml")]
namespace AspNetCore
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
#line 1 "D:\Dogan\Example\Agackakan\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Entities.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46df7605b5587892b33cac34e40aa1278d0bfb9f", @"/Areas/Admin/Views/Categories/Save.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1e5c08bf62f543cf17849415f6899d31a9729cc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Categories_Save : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/views/admin/categories/save.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Dogan\Example\Agackakan\WebUI\Areas\Admin\Views\Categories\Save.cshtml"
  
    ViewData["Title"] = "Kategori Yönetimi";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 134, "\"", 200, 1);
#nullable restore
#line 6 "D:\Dogan\Example\Agackakan\WebUI\Areas\Admin\Views\Categories\Save.cshtml"
WriteAttributeValue("", 142, Convert.ToInt32(Url.ActionContext.RouteData.Values["id"]), 142, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""txtId"" />
<div class=""page-header page-header-light"">
    <div class=""breadcrumb-line breadcrumb-line-light header-elements-md-inline"">
        <div class=""d-flex"">
            <div class=""breadcrumb"">
                <a href=""/admin/admin/index"" class=""breadcrumb-item""><i class=""icon-home2 mr-2""></i> Anasayfa</a>
                <span class=""breadcrumb-item active"">Kategori Yönetimi</span>
            </div>
            <a href=""#"" class=""header-elements-toggle text-default d-md-none""><i class=""icon-more""></i></a>
        </div>
    </div>
</div>
<div class=""content"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body m-4"">
                    <div class=""form-group row"">
                        <label class=""col-form-label col-12 col-lg-2"">Kategori Adı</label>
                        <div class=""col-12 col-lg-10"">
                            <input type=""text"" id=""txtCategoryName"" maxlength=""100"" placeholder=""Kateg");
            WriteLiteral(@"ori Adı Giriniz"" class=""form-control"" />
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-12 col-lg-2"">Sıra No</label>
                        <div class=""col-12 col-lg-10"">
                            <input type=""text"" id=""txtOrderNumber"" class=""form-control order"" maxlength=""2"" />
                        </div>
                    </div>
                </div>
                <div class=""card-footer text-right"">
                    <a href=""/admin/categories/index"" class=""btn bg-slate btn-sm"">
                        <i class=""fas fa-arrow-circle-left""></i>
                        Listeye Dön
                    </a>
                    <button class=""btn btn-success btn-sm"" id=""btnSave"">
                        <i class=""fa fa-save""></i>
                        Kaydet
                    </button>
                </div>
            </div>
        </div>
    </div>
</div");
            WriteLiteral(">\r\n");
            DefineSection("js", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46df7605b5587892b33cac34e40aa1278d0bfb9f6395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591