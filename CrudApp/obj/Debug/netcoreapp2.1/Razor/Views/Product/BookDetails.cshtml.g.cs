#pragma checksum "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67cb45e76deaa9acbe5dd4237b54b473fb30590c"
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
#line 1 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\_ViewImports.cshtml"
using CrudApp.Db.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cb45e76deaa9acbe5dd4237b54b473fb30590c", @"/Views/Product/BookDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a3e2be61408e5d05d7a376eec90949ea98f5bd", @"/Views/_ViewImports.cshtml")]
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
#line 3 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
  
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
            BeginContext(91, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(99, 3738, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3782c8cb346d46f5bd22d9b1b6dc6ace", async() => {
                BeginContext(105, 1079, true);
                WriteLiteral(@"
    
    <div class=""metro_subheader dark-overlay dark-overlay-2"" style=""        background-image: url(/Public/metropolitanhost.com/themes/themeforest/html/trickly/assets/img/subheader.jpg)"">
        <div class=""container"">
            <div class=""metro_subheader-inner"">
                <h1>Recipe Details</h1>
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Book Details</li>
                    </ol>
                </nav>
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
                    <div class=""metro_post-single-wrapper metro_recipe-single-wrappe");
                WriteLiteral("r\">\r\n\r\n                        <h2 class=\"entry-title\">");
                EndContext();
                BeginContext(1185, 10, false);
#line 33 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1195, 102, true);
                WriteLiteral("</h2>\r\n\r\n\r\n                        <div class=\"metro_post-single-thumb\">\r\n                            ");
                EndContext();
                BeginContext(1297, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3818d057e64d4562a56261f2c13c184a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1307, "~/Image/", 1307, 8, true);
#line 37 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
AddHtmlAttributeValue("", 1315, Model.Image, 1315, 12, false);

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
                BeginContext(1365, 99, true);
                WriteLiteral("\r\n                            <div class=\"metro_post-date\">\r\n                                <span>");
                EndContext();
                BeginContext(1465, 11, false);
#line 39 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                 Write(ViewBag.day);

#line default
#line hidden
                EndContext();
                BeginContext(1476, 47, true);
                WriteLiteral("</span>\r\n                                <span>");
                EndContext();
                BeginContext(1524, 13, false);
#line 40 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                 Write(ViewBag.Month);

#line default
#line hidden
                EndContext();
                BeginContext(1537, 248, true);
                WriteLiteral("</span>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                        <!-- Entry Content Start -->\r\n                        <div class=\"entry-content\">\r\n                            <span class=\"metro_post-meta\">\r\n");
                EndContext();
                BeginContext(1885, 92, true);
                WriteLiteral("\r\n                                <a href=\"blog-details.html\"> <i class=\"far fa-clock\"></i> ");
                EndContext();
                BeginContext(1978, 12, false);
#line 50 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                     Write(ViewBag.Date);

#line default
#line hidden
                EndContext();
                BeginContext(1990, 484, true);
                WriteLiteral(@" ago created by Nigar</a>
                            </span>



                            <div class=""row"">

                                <div class=""col-lg-6"">
                                    <div class=""metro_ingredients"">
                                        <h4>About</h4>
                                        <ul>

                                            <li>
                                                <i class=""fas fa-book"">Book Name:</i> ");
                EndContext();
                BeginContext(2475, 10, false);
#line 63 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                 Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2485, 145, true);
                WriteLiteral("\r\n                                            </li>\r\n\r\n                                            <li>  <i class=\"fas fa-user-edit\">Author:</i> ");
                EndContext();
                BeginContext(2631, 12, false);
#line 66 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                     Write(Model.Author);

#line default
#line hidden
                EndContext();
                BeginContext(2643, 97, true);
                WriteLiteral(" </li>\r\n                                            <li>  <i class=\"fas fa-book\">Page Count:</i> ");
                EndContext();
                BeginContext(2741, 15, false);
#line 67 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                                                                    Write(Model.PageCount);

#line default
#line hidden
                EndContext();
                BeginContext(2756, 564, true);
                WriteLiteral(@" </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>



                            <div class=""row"">

                                <div class=""col-lg-10"">
                                    <div class=""metro_ingredients"">
                                        <h4>Description</h4>
                                        <ul>

                                            <li>
                                                ");
                EndContext();
                BeginContext(3321, 17, false);
#line 83 "D:\COVID1904\.NETCORE\Product\CrudApp\Views\Product\BookDetails.cshtml"
                                           Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(3338, 492, true);
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
            BeginContext(3837, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrudApp.Db.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
