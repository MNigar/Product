#pragma checksum "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a83b6fcf3e631f421f1ccefc8d0d7e61468191c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Search.cshtml", typeof(AspNetCore.Views_Product_Search))]
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
#line 1 "D:\MyProject\Product\CrudApp\Views\_ViewImports.cshtml"
using CrudApp.Db.Models;

#line default
#line hidden
#line 2 "D:\MyProject\Product\CrudApp\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 3 "D:\MyProject\Product\CrudApp\Views\_ViewImports.cshtml"
using CrudApp.Resource;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a83b6fcf3e631f421f1ccefc8d0d7e61468191c", @"/Views/Product/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9ad9f0facca0cf8feeac97551027156590c5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudApp.Db.Models.Product>>
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
#line 3 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
  
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
            BeginContext(104, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(112, 3861, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb1315be4214eadb3291b9e0641420c", async() => {
                BeginContext(118, 62, true);
                WriteLiteral("\r\n    <div class=\"metro_subheader dark-overlay dark-overlay-2\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 180, "\"", 301, 4);
                WriteAttributeValue("", 188, "background-image:", 188, 17, true);
                WriteAttributeValue(" ", 205, "url(/Public/metropolitanhost.com/themes/themeforest/html/trickly/assets/img/", 206, 77, true);
#line 8 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 282, ViewData["image"], 282, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 300, ")", 300, 1, true);
                EndWriteAttribute();
                BeginContext(302, 105, true);
                WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"metro_subheader-inner\">\r\n                <h1>");
                EndContext();
                BeginContext(408, 24, false);
#line 11 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
               Write(stringLocalizer["Books"]);

#line default
#line hidden
                EndContext();
                BeginContext(432, 120, true);
                WriteLiteral("</h1>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Subheader End -->\r\n    <!-- Blog Posts Start -->\r\n    ");
                EndContext();
                BeginContext(552, 3384, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8b83e623704e35b323aa3279b6bc9d", async() => {
                    BeginContext(558, 253, true);
                    WriteLiteral("\r\n        <div class=\"section\">\r\n\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n\r\n\r\n                        <div class=\"col-md-4\">\r\n                            <label for=\"endDate\">");
                    EndContext();
                    BeginContext(812, 23, false);
#line 27 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
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
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b2ee0f31441429e9c163756a329d7f6", async() => {
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
#line 35 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                                 foreach (var cat in ViewBag.Category)
                                {


#line default
#line hidden
                    BeginContext(1353, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(1389, 42, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddf7e3ca685e4e53b50cffb74c6fa758", async() => {
                        BeginContext(1414, 8, false);
#line 38 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                                                       Write(cat.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 38 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
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
#line 39 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                                }

#line default
#line hidden
                    BeginContext(1468, 156, true);
                    WriteLiteral("                            </select>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"col-md-4\">\r\n                            <div>");
                    EndContext();
                    BeginContext(1625, 25, false);
#line 45 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                            Write(stringLocalizer["Author"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1650, 407, true);
                    WriteLiteral(@"</div>

                            <input type=""text"" id=""endDate"" name=""Author""  class=""form-control"">

                        </div>
                        <div class=""text-left"">
                            <input type=""submit"" value=""Searh"" class=""mt-4 metro_btn-custom"" name=""button"" formaction=""/Product/Search/"" formmethod=""GET"">
                        </div>
                    </div>
");
                    EndContext();
                    BeginContext(2085, 87, true);
                    WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"row\">\r\n\r\n");
                    EndContext();
#line 60 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                     foreach (var i in Model)
                    {


#line default
#line hidden
                    BeginContext(2244, 290, true);
                    WriteLiteral(@"                        <!-- Recipe Start -->
                        <div class=""col-lg-4 col-md-6"">
                            <article class=""metro_post metro_recipe"">
                                <div class=""metro_post-thumb"" alt=""recipe"">
                                    <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 2534, "\"", 2567, 2);
                    WriteAttributeValue("", 2541, "/Product/BookDetails/", 2541, 21, true);
#line 67 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 2562, i.Id, 2562, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2568, 45, true);
                    WriteLiteral(">\r\n\r\n                                        ");
                    EndContext();
                    BeginContext(2613, 82, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a33349a6b654caf8d5e034ef3ab5b25", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 2623, "~/Image/", 2623, 8, true);
#line 69 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
AddHtmlAttributeValue("", 2631, i.Image, 2631, 8, false);

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
                    BeginContext(2695, 326, true);
                    WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""metro_post-body"">
                                    <div class=""metro_post-desc"">
                                        <span class=""metro_post-meta""> <a href=""#""> <i class=""fas fa-book""></i> ");
                    EndContext();
                    BeginContext(3022, 11, false);
#line 74 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                                                                                                           Write(i.PageCount);

#line default
#line hidden
                    EndContext();
                    BeginContext(3033, 8, true);
                    WriteLiteral(" </a> <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3041, "\"", 3074, 2);
                    WriteAttributeValue("", 3048, "/Product/BookDetails/", 3048, 21, true);
#line 74 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 3069, i.Id, 3069, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3075, 35, true);
                    WriteLiteral("> <i class=\"fas fa-user-edit\"></i> ");
                    EndContext();
                    BeginContext(3111, 8, false);
#line 74 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                                                                                                                                                                                                    Write(i.Author);

#line default
#line hidden
                    EndContext();
                    BeginContext(3119, 61, true);
                    WriteLiteral("</a> </span>\r\n                                        <h5> <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3180, "\"", 3213, 2);
                    WriteAttributeValue("", 3187, "/Product/BookDetails/", 3187, 21, true);
#line 75 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 3208, i.Id, 3208, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3214, 1, true);
                    WriteLiteral(">");
                    EndContext();
                    BeginContext(3216, 6, false);
#line 75 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                                                                             Write(i.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(3222, 12, true);
                    WriteLiteral("</a> </h5>\r\n");
                    EndContext();
                    BeginContext(3320, 99, true);
                    WriteLiteral("                                    </div>\r\n                                    <a class=\"btn-link\"");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3419, "\"", 3452, 2);
                    WriteAttributeValue("", 3426, "/Product/BookDetails/", 3426, 21, true);
#line 78 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 3447, i.Id, 3447, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3453, 210, true);
                    WriteLiteral("> Read More <i class=\"fas fa-arrow-right\"></i> </a>\r\n                                </div>\r\n                            </article>\r\n                        </div>\r\n                        <!-- Recipe End -->\r\n");
                    EndContext();
#line 83 "D:\MyProject\Product\CrudApp\Views\Product\Search.cshtml"
                    }

#line default
#line hidden
                    BeginContext(3686, 223, true);
                    WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <!-- Pagination Start -->\r\n\r\n                <!-- Pagination End -->\r\n\r\n            </div>\r\n        </div>\r\n        <!-- Blog Posts End -->\r\n        <!-- Instagram Start -->\r\n");
                    EndContext();
                    BeginContext(3925, 4, true);
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
                BeginContext(3936, 30, true);
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
            BeginContext(3973, 9, true);
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
