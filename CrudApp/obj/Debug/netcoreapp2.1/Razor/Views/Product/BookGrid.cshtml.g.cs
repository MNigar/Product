#pragma checksum "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83d306a829440f49f5b0b5b77d86f05cf2e6e63b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83d306a829440f49f5b0b5b77d86f05cf2e6e63b", @"/Views/Product/BookGrid.cshtml")]
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
            BeginContext(112, 4787, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e883d5b5af894772a6a4647236e5b010", async() => {
                BeginContext(118, 732, true);
                WriteLiteral(@"
    <div class=""metro_subheader dark-overlay dark-overlay-2"" style=""        background-image: url(/Public/metropolitanhost.com/themes/themeforest/html/trickly/assets/img/subheader.jpg)"">
        <div class=""container"">
            <div class=""metro_subheader-inner"">
                <h1>Recipes</h1>
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Recipes</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
    <!-- Subheader End -->
    <!-- Blog Posts Start -->
    ");
                EndContext();
                BeginContext(850, 4012, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71058087273d4e1081724ac5f829697f", async() => {
                    BeginContext(856, 602, true);
                    WriteLiteral(@"
        <div class=""section"">

            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">


                        <div class=""col-md-4"">
                            <label for=""endDate"">Book</label>
                            <input type=""text"" id=""endDate"" name=""Name"" class=""form-control"">
                        </div>

                        <div class=""col-md-4"">
                            <div>Category</div>
                            <select class=""form-control"" name=""categoryId"">
                                ");
                    EndContext();
                    BeginContext(1458, 62, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b469687bbe2046609c16da4cd6633413", async() => {
                        BeginContext(1500, 11, true);
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
                    BeginContext(1520, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 40 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                 foreach (var cat in Model)
                                {


#line default
#line hidden
                    BeginContext(1620, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(1656, 42, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b6852f7a7564bcc821145c3b7269280", async() => {
                        BeginContext(1681, 8, false);
#line 43 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                                       Write(cat.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 43 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
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
                    BeginContext(1698, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 44 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                }

#line default
#line hidden
                    BeginContext(1735, 571, true);
                    WriteLiteral(@"                            </select>
                        </div>


                        <div class=""col-md-4"">
                            <div>CreatedUser</div>

                            <input type=""text"" id=""endDate"" name=""user"" class=""form-control"">

                        </div>
                        <div class=""text-left"">
                            <input type=""submit"" value=""Searh"" class=""mt-4 metro_btn-custom"" name=""button"" formaction=""/Recipes/Search/"" formmethod=""GET"">
                        </div>
                    </div>
");
                    EndContext();
                    BeginContext(2334, 87, true);
                    WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"row\">\r\n\r\n");
                    EndContext();
#line 65 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                     foreach (var i in Model)
                    {
                       

#line default
#line hidden
                    BeginContext(2516, 292, true);
                    WriteLiteral(@"                        <!-- Recipe Start -->
                        <div class=""col-lg-4 col-md-6"">
                            <article class=""metro_post metro_recipe"" >
                                <div class=""metro_post-thumb""  alt=""recipe"">
                                    <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 2808, "\"", 2841, 2);
                    WriteAttributeValue("", 2815, "/Product/BookDetails/", 2815, 21, true);
#line 72 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 2836, i.Id, 2836, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2842, 45, true);
                    WriteLiteral(">\r\n\r\n                                        ");
                    EndContext();
                    BeginContext(2887, 84, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a00acb484754905877448a0ba24b65f", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 2897, "~/Image/", 2897, 8, true);
#line 74 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
AddHtmlAttributeValue("", 2905, i.Image, 2905, 8, false);

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
                    BeginContext(2971, 326, true);
                    WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""metro_post-body"">
                                    <div class=""metro_post-desc"">
                                        <span class=""metro_post-meta""> <a href=""#""> <i class=""fas fa-book""></i> ");
                    EndContext();
                    BeginContext(3298, 11, false);
#line 79 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                                                                                           Write(i.PageCount);

#line default
#line hidden
                    EndContext();
                    BeginContext(3309, 8, true);
                    WriteLiteral(" </a> <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3317, "\"", 3350, 2);
                    WriteAttributeValue("", 3324, "/Product/BookDetails/", 3324, 21, true);
#line 79 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 3345, i.Id, 3345, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3351, 35, true);
                    WriteLiteral("> <i class=\"fas fa-user-edit\"></i> ");
                    EndContext();
                    BeginContext(3387, 8, false);
#line 79 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                                                                                                                                                                                    Write(i.Author);

#line default
#line hidden
                    EndContext();
                    BeginContext(3395, 61, true);
                    WriteLiteral("</a> </span>\r\n                                        <h5> <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3456, "\"", 3489, 2);
                    WriteAttributeValue("", 3463, "/Product/BookDetails/", 3463, 21, true);
#line 80 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 3484, i.Id, 3484, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3490, 1, true);
                    WriteLiteral(">");
                    EndContext();
                    BeginContext(3492, 6, false);
#line 80 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                                                                             Write(i.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(3498, 12, true);
                    WriteLiteral("</a> </h5>\r\n");
                    EndContext();
                    BeginContext(3596, 99, true);
                    WriteLiteral("                                    </div>\r\n                                    <a class=\"btn-link\"");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3695, "\"", 3728, 2);
                    WriteAttributeValue("", 3702, "/Product/BookDetails/", 3702, 21, true);
#line 83 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
WriteAttributeValue("", 3723, i.Id, 3723, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3729, 210, true);
                    WriteLiteral("> Read More <i class=\"fas fa-arrow-right\"></i> </a>\r\n                                </div>\r\n                            </article>\r\n                        </div>\r\n                        <!-- Recipe End -->\r\n");
                    EndContext();
#line 88 "D:\CrudApp\CrudApp\Views\Product\BookGrid.cshtml"
                    }

#line default
#line hidden
                    BeginContext(3962, 873, true);
                    WriteLiteral(@"


                </div>

                <!-- Pagination Start -->
                <ul class=""pagination mb-0"">
                    <li class=""page-item""><a class=""page-link"" href=""#""> <i class=""fas fa-arrow-left""></i> </a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                    <li class=""page-item active"">
                        <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#""> <i class=""fas fa-arrow-right""></i> </a></li>
                </ul>
                <!-- Pagination End -->

            </div>
        </div>
        <!-- Blog Posts End -->
        <!-- Instagram Start -->
");
                    EndContext();
                    BeginContext(4851, 4, true);
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
                BeginContext(4862, 30, true);
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
            BeginContext(4899, 9, true);
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
