#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded51f264fd3ba26afa2834b4653c5b0e291e948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity.message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\_ViewImports.cshtml"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
using shopapp.webui.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded51f264fd3ba26afa2834b4653c5b0e291e948", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c264a29427cb1155e5acff213e4524f9c5f3eaaf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoriesViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" \r\n");
#nullable restore
#line 4 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-body\">\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-md-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ded51f264fd3ba26afa2834b4653c5b0e291e9484882", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 323, "~/img/", 323, 6, true);
#nullable restore
#line 15 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
AddHtmlAttributeValue("", 329, Model.Product.ImageUrl, 329, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                \r\n                    <h1 class=\"card-title mb-3\">");
#nullable restore
#line 19 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
                                           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><hr>\r\n                    <a class=\"btn btn-link p-0 mb-3\">\r\n");
#nullable restore
#line 21 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
                         foreach (var item in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-link p-0 mb-3\"> ");
#nullable restore
#line 23 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 24 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </a>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
                                    Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"mb-3\">\r\n                        <h4 class=\"text-primary mb-3\">\r\n                            ");
#nullable restore
#line 29 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
                       Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h4>
                    </div>
                    <button type=""submit"" class=""btn btn-primary btn-large"">Add To Card</button>
            
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <p class=""p-3"">");
#nullable restore
#line 38 "C:\Users\Mehmet Kelleli\Desktop\myblog\shopudemy(update)\shopapp.webui\Views\Shop\Details.cshtml"
                          Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoriesViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591