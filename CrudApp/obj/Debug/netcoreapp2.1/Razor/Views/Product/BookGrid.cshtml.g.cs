#pragma checksum "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cb96effb5af47985c03d2f5e3ea970a71517cf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_BookGrid), @"mvc.1.0.view", @"/Views/Product/BookGrid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/BookGrid.cshtml", typeof(AspNetCore.Views_Product_BookGrid))]
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
#line 1 "D:\CrudApp\CrudApp\Views\_ViewImports.cshtml"
using CrudApp.Db.Models;

#line default
#line hidden
#line 2 "D:\CrudApp\CrudApp\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 3 "D:\CrudApp\CrudApp\Views\_ViewImports.cshtml"
using CrudApp.Resource;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb96effb5af47985c03d2f5e3ea970a71517cf5", @"/Views/Product/BookGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9ad9f0facca0cf8feeac97551027156590c5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_BookGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudApp.Db.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 400px; width:400px; object-fit: cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
  
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
            BeginContext(104, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(112, 3787, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc77aaad75fa458ca97a4dcd4b22dcae", async() => {
                BeginContext(118, 62, true);
                WriteLiteral("\r\n    <div class=\"metro_subheader dark-overlay dark-overlay-2\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 180, "\"", 301, 4);
                WriteAttributeValue("", 188, "background-image:", 188, 17, true);
                WriteAttributeValue(" ", 205, "url(/Public/metropolitanhost.com/themes/themeforest/html/trickly/assets/img/", 206, 77, true);
#line 8 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 282, ViewData["image"], 282, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 300, ")", 300, 1, true);
                EndWriteAttribute();
                BeginContext(302, 105, true);
                WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"metro_subheader-inner\">\r\n                <h1>");
                EndContext();
                BeginContext(408, 24, false);
#line 11 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
               Write(stringLocalizer["Books"]);

#line default
#line hidden
                EndContext();
                BeginContext(432, 120, true);
                WriteLiteral("</h1>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Subheader End -->\r\n    <!-- Blog Posts Start -->\r\n    ");
                EndContext();
                BeginContext(552, 3310, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5573f7747ad34021be74049948debf14", async() => {
                    BeginContext(558, 253, true);
                    WriteLiteral("\r\n        <div class=\"section\">\r\n\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n\r\n\r\n                        <div class=\"col-md-4\">\r\n                            <label for=\"endDate\">");
                    EndContext();
                    BeginContext(812, 23, false);
#line 27 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                            Write(stringLocalizer["Book"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(835, 345, true);
                    WriteLiteral(@"</label>
                            <input type=""text"" id=""endDate"" name=""Name"" class=""form-control"">
                        </div>

                        <div class=""col-md-4"">
                            <div>Category</div>
                            <select class=""form-control"" name=""categoryId"">
                                ");
                    EndContext();
                    BeginContext(1180, 62, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b298995f54e40f9a336975ad3f15b4d", async() => {
                        BeginContext(1222, 11, true);
                        WriteLiteral("Choose here");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1242, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 35 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                 foreach (var cat in ViewBag.Category)
                                {


#line default
#line hidden
                    BeginContext(1353, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(1389, 42, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec5a5e4346274d05860f03825ebe298f", async() => {
                        BeginContext(1414, 8, false);
#line 38 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                                       Write(cat.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 38 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                       WriteLiteral(cat.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1431, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 39 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                }

#line default
#line hidden
                    BeginContext(1468, 156, true);
                    WriteLiteral("                            </select>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"col-md-4\">\r\n                            <div>");
                    EndContext();
                    BeginContext(1625, 25, false);
#line 45 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                            Write(stringLocalizer["Author"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1650, 406, true);
                    WriteLiteral(@"</div>

                            <input type=""text"" id=""endDate"" name=""Author"" class=""form-control"">

                        </div>
                        <div class=""text-left"">
                            <input type=""submit"" value=""Searh"" class=""mt-4 metro_btn-custom"" name=""button"" formaction=""/Product/Search/"" formmethod=""GET"">
                        </div>
                    </div>
");
                    EndContext();
                    BeginContext(2084, 87, true);
                    WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"row\">\r\n\r\n");
                    EndContext();
#line 60 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                     foreach (var i in Model)
                    {


#line default
#line hidden
                    BeginContext(2243, 290, true);
                    WriteLiteral(@"                        <!-- Recipe Start -->
                        <div class=""col-lg-4 col-md-6"">
                            <article class=""metro_post metro_recipe"">
                                <div class=""metro_post-thumb"" alt=""recipe"">
                                    <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 2533, "\"", 2566, 2);
                    WriteAttributeValue("", 2540, "/Product/BookDetails/", 2540, 21, true);
#line 67 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 2561, i.Id, 2561, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2567, 45, true);
                    WriteLiteral(">\r\n\r\n                                        ");
                    EndContext();
                    BeginContext(2612, 82, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbff9e8664754c72a981bdec88baf06c", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 2622, "~/Image/", 2622, 8, true);
#line 69 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
AddHtmlAttributeValue("", 2630, i.Image, 2630, 8, false);

#line default
#line hidden
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2694, 326, true);
                    WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""metro_post-body"">
                                    <div class=""metro_post-desc"">
                                        <span class=""metro_post-meta""> <a href=""#""> <i class=""fas fa-book""></i> ");
                    EndContext();
                    BeginContext(3021, 11, false);
#line 74 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                                                                                           Write(i.PageCount);

#line default
#line hidden
                    EndContext();
                    BeginContext(3032, 8, true);
                    WriteLiteral(" </a> <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3040, "\"", 3073, 2);
                    WriteAttributeValue("", 3047, "/Product/BookDetails/", 3047, 21, true);
#line 74 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 3068, i.Id, 3068, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3074, 35, true);
                    WriteLiteral("> <i class=\"fas fa-user-edit\"></i> ");
                    EndContext();
                    BeginContext(3110, 8, false);
#line 74 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                                                                                                                                                                                    Write(i.Author);

#line default
#line hidden
                    EndContext();
                    BeginContext(3118, 61, true);
                    WriteLiteral("</a> </span>\r\n                                        <h5> <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3179, "\"", 3212, 2);
                    WriteAttributeValue("", 3186, "/Product/BookDetails/", 3186, 21, true);
#line 75 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 3207, i.Id, 3207, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3213, 1, true);
                    WriteLiteral(">");
                    EndContext();
                    BeginContext(3215, 6, false);
#line 75 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                                                             Write(i.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(3221, 12, true);
                    WriteLiteral("</a> </h5>\r\n");
                    EndContext();
                    BeginContext(3319, 99, true);
                    WriteLiteral("                                    </div>\r\n                                    <a class=\"btn-link\"");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3418, "\"", 3451, 2);
                    WriteAttributeValue("", 3425, "/Product/BookDetails/", 3425, 21, true);
#line 78 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 3446, i.Id, 3446, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3452, 210, true);
                    WriteLiteral("> Read More <i class=\"fas fa-arrow-right\"></i> </a>\r\n                                </div>\r\n                            </article>\r\n                        </div>\r\n                        <!-- Recipe End -->\r\n");
                    EndContext();
#line 83 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                    }

#line default
#line hidden
                    BeginContext(3685, 150, true);
                    WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n           \r\n\r\n            </div>\r\n        </div>\r\n        <!-- Blog Posts End -->\r\n        <!-- Instagram Start -->\r\n");
                    EndContext();
                    BeginContext(3851, 4, true);
                    WriteLiteral("    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3862, 30, true);
                WriteLiteral("\r\n    <!-- Instagram End -->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3899, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> stringLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrudApp.Db.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
