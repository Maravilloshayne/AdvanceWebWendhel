#pragma checksum "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a14c4b7088bbffddc27e4c462b9ee4ff6d7f0f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
using AdvanceWebWendhel.Web.Infrastructures.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a14c4b7088bbffddc27e4c462b9ee4ff6d7f0f5", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76fb40c316850c5f0147a32d724140c512939a85", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvanceWebWendhel.Web.ViewModels.Products.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Upload Banner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Upload Thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/products?pageIndex=1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(124, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(222, 247, true);
            WriteLiteral("\r\n<h2>Index Products</h2>\r\n\r\n\r\n\r\n<div class=\"card-container col-md-8\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <div class=\"input-group mb-3\">\r\n                <input id=\"searchKeyword\" type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 469, "\"", 500, 1);
#line 18 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 477, Model.Products.Keyword, 477, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(501, 334, true);
            WriteLiteral(@" placeholder=""Search by title"" aria-label=""Search title"" aria-describedby=""basic-addon2"">
                <div class=""input-group-append"">
                    <button class=""btn btn-outline-secondary"" type=""button"" onclick=""searchTrigger()"">Search</button>
                </div>
            </div>
        </div>
    </div>

");
            EndContext();
#line 26 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
      
        if (Model.Products != null)
        {
            if (Model.Products.Items.Count > 0)
            {
                foreach (Product product in Model.Products.Items)
                {

#line default
#line hidden
            BeginContext(1041, 228, true);
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-sm-3\">\r\n                                    ");
            EndContext();
            BeginContext(1269, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb684c6df9064e2e84a9e7ff2e45bb22", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1279, "~/products/", 1279, 11, true);
#line 37 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1290, product.Id, 1290, 11, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1301, "/thumbnail.png", 1301, 14, true);
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
            BeginContext(1353, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-9\">\r\n                                    <h4>");
            EndContext();
            BeginContext(1492, 12, false);
#line 40 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                                   Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 46, true);
            WriteLiteral("</h4>\r\n                                    <p>");
            EndContext();
            BeginContext(1551, 19, false);
#line 41 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                                  Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1570, 139, true);
            WriteLiteral("</p>\r\n\r\n                                    <ul class=\"list-inline\">\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(1709, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1151de9f32d04c6bbde86b9865ce1f94", async() => {
                BeginContext(1782, 81, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1718, "~/manage/posts/update-banner/", 1718, 29, true);
#line 44 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1747, product.Id, 1747, 11, false);

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
            BeginContext(1867, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(1943, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9195560dab7c4100888449bbc6dc8bf6", async() => {
                BeginContext(2022, 86, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-file-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1952, "~/manage/posts/update-thumbnail/", 1952, 32, true);
#line 45 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1984, product.Id, 1984, 11, false);

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
            BeginContext(2112, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2188, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca45b98fab174d9eb0df4018cbffc9a6", async() => {
                BeginContext(2263, 84, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-file-alt\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2197, "~/manage/posts/update-content/", 2197, 30, true);
#line 46 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2227, product.Id, 2227, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2351, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2427, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe0d83792c542e599e70f97d2c0f5ec", async() => {
                BeginContext(2498, 83, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-pen-alt\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2436, "~/manage/posts/update-title/", 2436, 28, true);
#line 47 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2464, product.Id, 2464, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2585, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 48 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                                          
                                            if (product.IsPublished)
                                            {

#line default
#line hidden
            BeginContext(2753, 106, true);
            WriteLiteral("                                                <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2859, "\"", 2916, 5);
            WriteAttributeValue("", 2869, "confirmUnpublish(\'", 2869, 18, true);
#line 51 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 2887, product.Id, 2887, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2898, "\',\'", 2898, 3, true);
#line 51 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 2901, product.Name, 2901, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2914, "\')", 2914, 2, true);
            EndWriteAttribute();
            BeginContext(2917, 99, true);
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
            EndContext();
#line 52 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3160, 104, true);
            WriteLiteral("                                                <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3264, "\"", 3319, 5);
            WriteAttributeValue("", 3274, "confirmPublish(\'", 3274, 16, true);
#line 55 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 3290, product.Id, 3290, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3301, "\',\'", 3301, 3, true);
#line 55 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 3304, product.Name, 3304, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3317, "\')", 3317, 2, true);
            EndWriteAttribute();
            BeginContext(3320, 100, true);
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
            EndContext();
#line 56 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                                            }
                                        

#line default
#line hidden
            BeginContext(3510, 179, true);
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 63 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                }




#line default
#line hidden
            BeginContext(3714, 83, true);
            WriteLiteral("                <ul class=\"pagination\">\r\n                    <li class=\"page-item\">");
            EndContext();
            BeginContext(3797, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16985cc5a2a64fc69697bade45415fca", async() => {
                BeginContext(3853, 5, true);
                WriteLiteral("First");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3862, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 69 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                       if (Model.Products.PageIndex > 1)
                        {

#line default
#line hidden
            BeginContext(3954, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(4004, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60000638078f4e9cbd05115e383fd0c0", async() => {
                BeginContext(4092, 28, false);
#line 71 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                                                                                                                                    Write(Model.Products.PageIndex - 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4031, "~/home/products?pageIndex=", 4031, 26, true);
#line 71 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 4057, Model.Products.PageIndex - 1, 4057, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4125, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 72 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4182, 79, true);
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link active\" href=\"#\">");
            EndContext();
            BeginContext(4263, 24, false);
#line 74 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                                                                           Write(Model.Products.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(4288, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 75 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                       if ((Model.Products.PageIndex + 1) <= Model.Products.PageCount)
                        {

#line default
#line hidden
            BeginContext(4414, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(4464, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d9d4ac2ac334aec8cd06e151b85ebfe", async() => {
                BeginContext(4552, 28, false);
#line 77 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                                                                                                                                    Write(Model.Products.PageIndex + 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4491, "~/home/products?pageIndex=", 4491, 26, true);
#line 77 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 4517, Model.Products.PageIndex + 1, 4517, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4585, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 78 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4642, 42, true);
            WriteLiteral("                    <li class=\"page-item\">");
            EndContext();
            BeginContext(4684, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddaa5b9abb3a4ed687e4d94333a8f7f6", async() => {
                BeginContext(4764, 4, true);
                WriteLiteral("Last");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4711, "~/home/products?pageIndex=", 4711, 26, true);
#line 80 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 4737, Model.Products.PageCount, 4737, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4772, 30, true);
            WriteLiteral("</li>\r\n                </ul>\r\n");
            EndContext();
#line 82 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebWendhel\AdvanceWebWendhel.Web\Views\Products\Index.cshtml"
            }
        }
    

#line default
#line hidden
            BeginContext(4835, 1872, true);
            WriteLiteral(@"
</div>



<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Unpublish Product</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to unpublish <span id=""modal-unpublish-title""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-unpublish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-publ");
            WriteLiteral(@"ish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Publish Product</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to publish <span id=""modal-publish-title""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-publish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("pageStyles", async() => {
                BeginContext(6727, 254, true);
                WriteLiteral("\r\n    <style>\r\n        h2 {\r\n            margin-top: 30px;\r\n        }\r\n\r\n        .card-container {\r\n            margin-bottom: 30px;\r\n        }\r\n\r\n        .card {\r\n            margin-top: 15px;\r\n            margin-bottom: 15px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(6984, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(7009, 2254, true);
                WriteLiteral(@"
    <script>

        //////////////////////SEARCH/////////////////////////////////////////////////////////////////
        function searchTrigger() {
            window.location = ""/home/products?pageIndex=1&keyword="" + $(""#searchKeyword"").val();
        }

        $(""#searchKeyword"").keyup(function (event) {
            if (event.keyCode === 13) {
                searchTrigger();
            }
        });


        ////////////////////UNPUBLISH/////////////////////////////////////////////////////////////////
        function confirmUnpublish(id, title) {
            $(""#modal-unpublish-title"").html(title);
            $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishProducts('"" + id + ""')"");
            $(""#modal-unpublish"").modal(""show"");
        }

        function UnpublishProducts(id) {
            $.ajax({
                type: ""POST"",
                url: ""/home/products/unpublish"",
                data: { id: id },
                success: function (data) {
        ");
                WriteLiteral(@"            location.reload();
                },
                error: function (xhr) {
                    var response = JSON.parse(xhr.responseText);
                    alert(""Error Occured : "" + response.errors[0]);
                    location.reload();
                }
            });
        }

        //////////////////PUBLISH///////////////////////////////////////////////////////////////////////
        function confirmPublish(id, title) {
            $(""#modal-publish-title"").html(title);
            $(""#modal-publish-button"").attr(""onclick"", ""PublishProducts('"" + id + ""')"");
            $(""#modal-publish"").modal(""show"");
        }

        function PublishProducts(id) {
            $.ajax({
                type: ""POST"",
                url: ""/home/products/publish"",
                data: { id: id },
                success: function (data) {
                    location.reload();
                },
                error: function (xhr) {
                    var respons");
                WriteLiteral("e = JSON.parse(xhr.responseText);\r\n                    alert(\"Error Occured : \" + response.errors[0]);\r\n                    location.reload();\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvanceWebWendhel.Web.ViewModels.Products.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591