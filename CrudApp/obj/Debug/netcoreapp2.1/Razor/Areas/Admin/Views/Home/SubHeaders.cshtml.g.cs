#pragma checksum "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5cbb861f76458c2eef76c642aa7aeae51586b24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_SubHeaders), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/SubHeaders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/SubHeaders.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_SubHeaders))]
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
#line 1 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\_ViewImports.cshtml"
using CrudApp.Db.Models;

#line default
#line hidden
#line 2 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 3 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\_ViewImports.cshtml"
using CrudApp.Resource;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5cbb861f76458c2eef76c642aa7aeae51586b24", @"/Areas/Admin/Views/Home/SubHeaders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9ad9f0facca0cf8feeac97551027156590c5d5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_SubHeaders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudApp.Db.Models.SubHeader>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100px; width:100px; object-fit: cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditLogo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(99, 28, false);
#line 7 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
Write(stringLocalizer["SubHeader"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 166, true);
            WriteLiteral("</h2>\r\n<style>\r\n    td {\r\n        text-align: center;\r\n    }\r\n\r\n    th {\r\n        text-align: center;\r\n    }\r\n</style>\r\n<div class=\"container\">\r\n    <hr />\r\n    <p>\r\n");
            EndContext();
#line 20 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
            BeginContext(338, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(350, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a54148cd41fa4eaa9549942bf183a0d9", async() => {
                BeginContext(374, 25, false);
#line 22 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
                              Write(stringLocalizer["Create"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(403, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"

        }

#line default
#line hidden
            BeginContext(418, 131, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(550, 41, false);
#line 31 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
               Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(591, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(614, 24, false);
#line 32 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
               Write(stringLocalizer["Image"]);

#line default
#line hidden
            EndContext();
            BeginContext(638, 47, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>");
            EndContext();
            BeginContext(686, 26, false);
#line 35 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
               Write(stringLocalizer["Details"]);

#line default
#line hidden
            EndContext();
            BeginContext(712, 61, true);
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 39 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(830, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(903, 40, false);
#line 43 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
            EndContext();
            BeginContext(943, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(969, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e19c827bd00472a9ee26fa2f7eecc86", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 979, "~/Public/metropolitanhost.com/themes/themeforest/html/trickly/assets/img/", 979, 73, true);
#line 44 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
AddHtmlAttributeValue("", 1052, item.Image, 1052, 11, false);

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
            BeginContext(1119, 109, true);
            WriteLiteral("\r\n\r\n                        \r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1228, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0426c144691d4a7dafa37e432bda7014", async() => {
                BeginContext(1277, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1285, 78, true);
            WriteLiteral(" \r\n                       \r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 54 "D:\MyProject\Product\CrudApp\Areas\Admin\Views\Home\SubHeaders.cshtml"
            }

#line default
#line hidden
            BeginContext(1378, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrudApp.Db.Models.SubHeader>> Html { get; private set; }
    }
}
#pragma warning restore 1591
