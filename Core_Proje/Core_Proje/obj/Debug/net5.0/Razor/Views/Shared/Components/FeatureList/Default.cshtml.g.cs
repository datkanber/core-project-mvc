#pragma checksum "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "508b8ab422d5155c9620ab5c7743b06f9ffffd9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
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
#line 1 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"508b8ab422d5155c9620ab5c7743b06f9ffffd9f", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FeatureList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/illustrations/hello3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("hello"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<header>\r\n    <div class=\"cover bg-light\">\r\n        <div class=\"container px-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-6 p-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "508b8ab422d5155c9620ab5c7743b06f9ffffd9f4665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral("</div>\r\n                <div class=\"col-lg-6\">\r\n");
#nullable restore
#line 9 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mt-5\">\r\n                        <p class=\"lead text-uppercase mb-1\">");
#nullable restore
#line 12 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                                                       Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n                        <h1 class=\"intro-title marker\" data-aos=\"fade-left\" data-aos-delay=\"50\">");
#nullable restore
#line 13 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"lead fw-normal mt-3\" data-aos=\"fade-up\" data-aos-delay=\"100\">");
#nullable restore
#line 14 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
#nullable restore
#line 15 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                   Write(await Component.InvokeAsync("SocialMediaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"mt-3\" data-aos=\"fade-up\" data-aos-delay=\"200\"><a class=\"btn btn-primary shadow-sm mt-1 hover-effect\" href=\"#contact\">Bana Ulaşın <i class=\"fas fa-arrow-right\"></i></a></div>\r\n                    </div>\r\n");
#nullable restore
#line 18 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"wave-bg\"></div>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
