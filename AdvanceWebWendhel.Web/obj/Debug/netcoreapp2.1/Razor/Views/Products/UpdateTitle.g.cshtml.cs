#pragma checksum "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\UpdateTitle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de3f9e8f0eefb5152f55a516a2d4e7050e85e889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_UpdateTitle), @"mvc.1.0.view", @"/Views/Products/UpdateTitle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/UpdateTitle.cshtml", typeof(AspNetCore.Views_Products_UpdateTitle))]
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
#line 1 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\_ViewImports.cshtml"
using AdvanceWebWendhel.Web;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\_ViewImports.cshtml"
using AdvanceWebWendhel.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de3f9e8f0eefb5152f55a516a2d4e7050e85e889", @"/Views/Products/UpdateTitle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76fb40c316850c5f0147a32d724140c512939a85", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_UpdateTitle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvanceWebWendhel.Web.ViewModels.Products.UpdateTitleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/products/update-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\UpdateTitle.cshtml"
  
    ViewData["Title"] = "UpdateTitle";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(171, 82, true);
            WriteLiteral("\r\n<h2>Update Title</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(253, 964, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb447f98a574b289153085609a59a0b", async() => {
                BeginContext(311, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(326, 24, false);
#line 12 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\UpdateTitle.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(350, 86, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 436, "\"", 453, 1);
#line 14 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\UpdateTitle.cshtml"
WriteAttributeValue("", 444, Model.Id, 444, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(454, 121, true);
                WriteLiteral(" />\r\n                <label for=\"Name\">Name:</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 575, "\"", 594, 1);
#line 16 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\UpdateTitle.cshtml"
WriteAttributeValue("", 583, Model.Name, 583, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(595, 222, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Description\">Description</label>\r\n                <textarea class=\"form-control\" rows=\"4\" name=\"Description\">\r\n                    ");
                EndContext();
                BeginContext(818, 17, false);
#line 21 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\UpdateTitle.cshtml"
               Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(835, 241, true);
                WriteLiteral("\r\n                </textarea>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Post Expiry\">Post Expiry:</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"PostExpiry\" id=\"postExpiry\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1076, "\"", 1101, 1);
#line 26 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\UpdateTitle.cshtml"
WriteAttributeValue("", 1084, Model.PostExpiry, 1084, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1102, 108, true);
                WriteLiteral(" />\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(1262, 127, true);
                WriteLiteral("\r\n    <script>\r\n    $(function () {\r\n        $(\"#postExpiry\").datepicker({ dateFormat: \'dd/mm/yy\' });\r\n    });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvanceWebWendhel.Web.ViewModels.Products.UpdateTitleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
