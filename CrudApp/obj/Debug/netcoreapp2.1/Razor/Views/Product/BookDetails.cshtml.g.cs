#pragma checksum "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01df9e5a5e3c73e3e6279430254e6b635ac07583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_BookDetails), @"mvc.1.0.view", @"/Views/Product/BookDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/BookDetails.cshtml", typeof(AspNetCore.Views_Product_BookDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01df9e5a5e3c73e3e6279430254e6b635ac07583", @"/Views/Product/BookDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9ad9f0facca0cf8feeac97551027156590c5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_BookDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrudApp.Db.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
  
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
            BeginContext(91, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(99, 3818, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84922f0b7ba1413388b55b71534c38f8", async() => {
                BeginContext(105, 68, true);
                WriteLiteral("\r\n    \r\n    <div class=\"metro_subheader dark-overlay dark-overlay-2\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 173, "\"", 294, 4);
                WriteAttributeValue("", 181, "background-image:", 181, 17, true);
                WriteAttributeValue(" ", 198, "url(/Public/metropolitanhost.com/themes/themeforest/html/trickly/assets/img/", 199, 77, true);
#line 9 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
WriteAttributeValue("", 275, ViewData["image"], 275, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 293, ")", 293, 1, true);
                EndWriteAttribute();
                BeginContext(295, 105, true);
                WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"metro_subheader-inner\">\r\n                <h1>");
                EndContext();
                BeginContext(401, 26, false);
#line 12 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
               Write(stringLocalizer["Details"]);

#line default
#line hidden
                EndContext();
                BeginContext(427, 466, true);
                WriteLiteral(@" </h1>
                
            </div>
        </div>
    </div>
    <!-- Subheader End -->
    <!-- Post Content Start -->
    <div class=""section metro_post-single"">
        <div class=""container"">

            <div class=""row"">
                <div class=""col-lg-8"">

                    <!-- Content  -->
                    <div class=""metro_post-single-wrapper metro_recipe-single-wrapper"">

                        <h2 class=""entry-title"">");
                EndContext();
                BeginContext(894, 10, false);
#line 28 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(904, 102, true);
                WriteLiteral("</h2>\r\n\r\n\r\n                        <div class=\"metro_post-single-thumb\">\r\n                            ");
                EndContext();
                BeginContext(1006, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73db9d8e805d4582a89c269eb64de931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1016, "~/Image/", 1016, 8, true);
#line 32 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
AddHtmlAttributeValue("", 1024, Model.Image, 1024, 12, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                EndContext();
                BeginContext(1074, 99, true);
                WriteLiteral("\r\n                            <div class=\"metro_post-date\">\r\n                                <span>");
                EndContext();
                BeginContext(1174, 11, false);
#line 34 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                 Write(ViewBag.day);

#line default
#line hidden
                EndContext();
                BeginContext(1185, 47, true);
                WriteLiteral("</span>\r\n                                <span>");
                EndContext();
                BeginContext(1233, 13, false);
#line 35 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                 Write(ViewBag.Month);

#line default
#line hidden
                EndContext();
                BeginContext(1246, 248, true);
                WriteLiteral("</span>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                        <!-- Entry Content Start -->\r\n                        <div class=\"entry-content\">\r\n                            <span class=\"metro_post-meta\">\r\n");
                EndContext();
                BeginContext(1594, 92, true);
                WriteLiteral("\r\n                                <a href=\"blog-details.html\"> <i class=\"far fa-clock\"></i> ");
                EndContext();
                BeginContext(1687, 12, false);
#line 45 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                     Write(ViewBag.Date);

#line default
#line hidden
                EndContext();
                BeginContext(1699, 288, true);
                WriteLiteral(@" ago created by Nigar</a>
                            </span>



                            <div class=""row"">

                                <div class=""col-lg-6"">
                                    <div class=""metro_ingredients"">
                                        <h4>");
                EndContext();
                BeginContext(1988, 24, false);
#line 54 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                       Write(stringLocalizer["About"]);

#line default
#line hidden
                EndContext();
                BeginContext(2012, 176, true);
                WriteLiteral("</h4>\r\n                                        <ul>\r\n\r\n                                            <li>\r\n                                                <i class=\"fas fa-book\">");
                EndContext();
                BeginContext(2189, 23, false);
#line 58 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                  Write(stringLocalizer["Name"]);

#line default
#line hidden
                EndContext();
                BeginContext(2212, 6, true);
                WriteLiteral(":</i> ");
                EndContext();
                BeginContext(2219, 10, false);
#line 58 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                                Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2229, 133, true);
                WriteLiteral("\r\n                                            </li>\r\n\r\n                                            <li>  <i class=\"fas fa-user-edit\">");
                EndContext();
                BeginContext(2363, 25, false);
#line 61 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                         Write(stringLocalizer["Author"]);

#line default
#line hidden
                EndContext();
                BeginContext(2388, 6, true);
                WriteLiteral(":</i> ");
                EndContext();
                BeginContext(2395, 12, false);
#line 61 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                                         Write(Model.Author);

#line default
#line hidden
                EndContext();
                BeginContext(2407, 81, true);
                WriteLiteral(" </li>\r\n                                            <li>  <i class=\"fas fa-book\">");
                EndContext();
                BeginContext(2489, 29, false);
#line 62 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                    Write(stringLocalizer["Page Count"]);

#line default
#line hidden
                EndContext();
                BeginContext(2518, 6, true);
                WriteLiteral(":</i> ");
                EndContext();
                BeginContext(2525, 15, false);
#line 62 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                                        Write(Model.PageCount);

#line default
#line hidden
                EndContext();
                BeginContext(2540, 81, true);
                WriteLiteral(" </li>\r\n                                            <li>  <i class=\"fas fa-book\">");
                EndContext();
                BeginContext(2622, 34, false);
#line 63 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                    Write(stringLocalizer["PublishingHouse"]);

#line default
#line hidden
                EndContext();
                BeginContext(2656, 6, true);
                WriteLiteral(":</i> ");
                EndContext();
                BeginContext(2663, 21, false);
#line 63 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                                             Write(Model.PublishingHouse);

#line default
#line hidden
                EndContext();
                BeginContext(2684, 81, true);
                WriteLiteral(" </li>\r\n                                            <li>  <i class=\"fas fa-book\">");
                EndContext();
                BeginContext(2766, 24, false);
#line 64 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                    Write(stringLocalizer["Genre"]);

#line default
#line hidden
                EndContext();
                BeginContext(2790, 6, true);
                WriteLiteral(":</i> ");
                EndContext();
                BeginContext(2797, 19, false);
#line 64 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                                   Write(Model.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2816, 400, true);
                WriteLiteral(@" </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>



                            <div class=""row"">

                                <div class=""col-lg-10"">
                                    <div class=""metro_ingredients"">
                                        <h4>");
                EndContext();
                BeginContext(3217, 30, false);
#line 76 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                       Write(stringLocalizer["Description"]);

#line default
#line hidden
                EndContext();
                BeginContext(3247, 153, true);
                WriteLiteral("</h4>\r\n                                        <ul>\r\n\r\n                                            <li>\r\n                                                ");
                EndContext();
                BeginContext(3401, 17, false);
#line 80 "D:\MyProject\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                           Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(3418, 492, true);
                WriteLiteral(@"
                                            </li>


                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <!-- Entry Content End -->

                        </div>




                    </div>



                </div>

            </div>
        </div>
        <!-- Product Content End -->
        <!-- Instagram Start -->

");
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
            BeginContext(3917, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrudApp.Db.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
