#pragma checksum "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4622a25508a2da21ea2ee43c67593bbdb832ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_HomePage), @"mvc.1.0.view", @"/Views/Product/HomePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/HomePage.cshtml", typeof(AspNetCore.Views_Product_HomePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4622a25508a2da21ea2ee43c67593bbdb832ec", @"/Views/Product/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9ad9f0facca0cf8feeac97551027156590c5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudApp.Db.Models.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 400px; width:400px; object-fit: cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("category"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(59, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(67, 6505, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "900c76f1347744b2bc0934b583159278", async() => {
                BeginContext(73, 118, true);
                WriteLiteral("\r\n\r\n\r\n    <!-- Header End -->\r\n    <!-- Banner Start -->\r\n    <div class=\"metro_subheader dark-overlay dark-overlay-2\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 191, "\"", 312, 4);
                WriteAttributeValue("", 199, "background-image:", 199, 17, true);
                WriteAttributeValue(" ", 216, "url(/Public/metropolitanhost.com/themes/themeforest/html/trickly/assets/img/", 217, 77, true);
#line 12 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
WriteAttributeValue("", 293, ViewData["image"], 293, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 311, ")", 311, 1, true);
                EndWriteAttribute();
                BeginContext(313, 266, true);
                WriteLiteral(@">

     
        <div class=""metro_banner-slider"">

            <!-- Banner Item Start -->
            <div class=""metro_banner-item"">

                <div class=""container"">
                    <div class=""metro_banner-text"">
                        <h1>");
                EndContext();
                BeginContext(580, 44, false);
#line 22 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                       Write(stringLocalizer["Welcome to World of Books"]);

#line default
#line hidden
                EndContext();
                BeginContext(624, 282, true);
                WriteLiteral(@"</h1>
                    </div>
                </div>

            </div>


        </div>



    </div>
    <!-- Banner End -->
    <!-- Categories Start -->
    <div class=""section section-padding"">
        <div class=""container"">
            <div class=""row"">
");
                EndContext();
#line 45 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                 foreach (var i in Model)
                {

#line default
#line hidden
                BeginContext(1354, 70, true);
                WriteLiteral("                    <div class=\"col-lg-4\">\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1424, "\"", 1454, 2);
                WriteAttributeValue("", 1431, "/Product/BookGrid/", 1431, 18, true);
#line 48 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
WriteAttributeValue("", 1449, i.Id, 1449, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1455, 69, true);
                WriteLiteral(" class=\"metro_recipe-category style-2\">\r\n                            ");
                EndContext();
                BeginContext(1524, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "56b62c68b765425b92af0e7c1bd39228", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1534, "~/Image/", 1534, 8, true);
#line 49 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
AddHtmlAttributeValue("", 1542, i.Image, 1542, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1621, 34, true);
                WriteLiteral("\r\n                            <h4>");
                EndContext();
                BeginContext(1656, 6, false);
#line 50 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                           Write(i.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1662, 65, true);
                WriteLiteral("</h4>\r\n                        </a>\r\n                    </div>\r\n");
                EndContext();
#line 53 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                }

#line default
#line hidden
                BeginContext(1746, 473, true);
                WriteLiteral(@"
               
            </div>
        </div>
    </div>
    <!-- Categories End -->

    <div class=""section pt-0"">
        <div class=""container"">
            <div class=""row"">

                <div class=""col-lg-8"">

                    <!-- Popular Recipes Start -->
                    <div class=""section p-0 metro_home-slider-wrapper"">
                        <div class=""section-title flex-title"">
                            <h4 class=""title"">");
                EndContext();
                BeginContext(2220, 32, false);
#line 70 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                         Write(stringLocalizer["Popular Books"]);

#line default
#line hidden
                EndContext();
                BeginContext(2252, 371, true);
                WriteLiteral(@"</h4>
                            <div class=""metro_arrows"">
                                <i class=""fa fa-arrow-left slick-arrow slider-prev""></i>
                                <i class=""fa fa-arrow-right slick-arrow slider-next""></i>
                            </div>
                        </div>

                        <div class=""metro_home-slider"">
");
                EndContext();
#line 78 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                             if (ViewBag.Book != null)
                            {
                                

#line default
#line hidden
#line 80 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                 foreach (var rec in @ViewBag.Book)
                                {

#line default
#line hidden
                BeginContext(2814, 275, true);
                WriteLiteral(@"                                    <!-- Recipe Start -->
                                    <article class=""metro_post metro_recipe metro_recipe-2"">


                                        <div class=""metro_post-thumb"">
                                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3089, "\"", 3124, 2);
                WriteAttributeValue("", 3096, "/Product/BookDetails/", 3096, 21, true);
#line 87 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
WriteAttributeValue("", 3117, rec.Id, 3117, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3125, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
                BeginContext(3225, 48, true);
                WriteLiteral("                                                ");
                EndContext();
                BeginContext(3273, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1cec9294d3a04c389d705d5976d4add5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3283, "~/Image/", 3283, 8, true);
#line 89 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
AddHtmlAttributeValue("", 3291, rec.Image, 3291, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3357, 250, true);
                WriteLiteral("\r\n                                            </a>\r\n                                        </div>\r\n\r\n\r\n                                        <div class=\"metro_post-body\">\r\n                                            <div class=\"metro_post-desc\">\r\n");
                EndContext();
                BeginContext(3786, 83, true);
                WriteLiteral("                                                <h5> <a href=\"recipe-details.html\">");
                EndContext();
                BeginContext(3870, 8, false);
#line 97 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                                                              Write(rec.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3878, 158, true);
                WriteLiteral("</a> </h5>\r\n                                            </div>\r\n                                        </div>\r\n                                    </article>");
                EndContext();
#line 100 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                              }

#line default
#line hidden
#line 100 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                               }

#line default
#line hidden
                BeginContext(4040, 1048, true);
                WriteLiteral(@"                            <!-- Recipe End -->
                            <!-- Recipe Start -->
                            <!-- Recipe End -->
                            <!-- Recipe Start -->
                            <!-- Recipe End -->
                            <!-- Recipe Start -->
                            <!-- Recipe End -->

                        </div>

                    </div>
                    <!-- Popular Recipes End -->
                    <!-- Recipes Start -->


                </div>

                <!-- sidebar Start -->
                <div class=""col-lg-4"">
                    <div class=""sidebar"">

                        <!-- Sidebar CTA Start -->
                        <!-- Sidebar CTA End -->
                        <!-- About author Start -->
                        <!-- about Author End -->
                        <!-- Recent Posts Start -->
                        <div class=""sidebar-widget widget-recent-posts"">
                            <");
                WriteLiteral("h5 class=\"widget-title\">");
                EndContext();
                BeginContext(5089, 31, false);
#line 128 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                                Write(stringLocalizer["Recent Posts"]);

#line default
#line hidden
                EndContext();
                BeginContext(5120, 7, true);
                WriteLiteral("</h5>\r\n");
                EndContext();
#line 129 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                             if (ViewBag.Book != null)
                            {
                                

#line default
#line hidden
#line 131 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                 foreach (var rec in @ViewBag.Book)
                                {

#line default
#line hidden
                BeginContext(5318, 102, true);
                WriteLiteral("                                    <article class=\"post\">\r\n                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5420, "\"", 5455, 2);
                WriteAttributeValue("", 5427, "/Product/BookDetails/", 5427, 21, true);
#line 134 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
WriteAttributeValue("", 5448, rec.Id, 5448, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5456, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(5457, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0452fc62cbc4b47b2075f2764966e1e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5467, "~/Image/", 5467, 8, true);
#line 134 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
AddHtmlAttributeValue("", 5475, rec.Image, 5475, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5498, 120, true);
                WriteLiteral("</a>\r\n                                        <div class=\"post-content\">\r\n                                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5618, "\"", 5653, 2);
                WriteAttributeValue("", 5625, "/Product/BookDetails/", 5625, 21, true);
#line 136 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
WriteAttributeValue("", 5646, rec.Id, 5646, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5654, 2, true);
                WriteLiteral("> ");
                EndContext();
                BeginContext(5657, 17, false);
#line 136 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                                                               Write(rec.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5674, 58, true);
                WriteLiteral(" </a>\r\n                                            <h6> <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5732, "\"", 5767, 2);
                WriteAttributeValue("", 5739, "/Product/BookDetails/", 5739, 21, true);
#line 137 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
WriteAttributeValue("", 5760, rec.Id, 5760, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5768, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(5770, 8, false);
#line 137 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                                                                   Write(rec.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5778, 108, true);
                WriteLiteral("</a> </h6>\r\n                                        </div>\r\n                                    </article>\r\n");
                EndContext();
#line 140 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"

                                }

#line default
#line hidden
#line 141 "D:\CrudApp\CrudApp\Views\Product\HomePage.cshtml"
                                 
                            }

#line default
#line hidden
                BeginContext(5954, 134, true);
                WriteLiteral("                        </div>\r\n                        <!-- Recent Posts End -->\r\n                        <!-- Categories Start -->\r\n");
                EndContext();
                BeginContext(6175, 390, true);
                WriteLiteral(@"

                        <!-- Categories End -->
                        <!-- Testimonials Start -->
                        <!-- Social Links End -->

                    </div>
                </div>
                <!-- Sidebar End -->

            </div>
        </div>
    </div>


    <!-- Instagram Start -->
    <!-- Instagram End -->
    <!-- Footer Start -->

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
            BeginContext(6572, 177, true);
            WriteLiteral("\r\n\r\n\r\n<!-- Mirrored from metropolitanhost.com/themes/themeforest/html/trickly/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Thu, 22 Apr 2021 08:51:41 GMT -->\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrudApp.Db.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
