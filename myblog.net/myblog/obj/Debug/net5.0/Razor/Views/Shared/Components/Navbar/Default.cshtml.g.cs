#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Navbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ce0b6bc0edf9123cd9331ec389c00c70634504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navbar/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\_ViewImports.cshtml"
using myblog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\_ViewImports.cshtml"
using PostCategoriesViewModel = myblog.model.PostCategoriesViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\_ViewImports.cshtml"
using MySettinViewmodel = myblog.model.MySettingViewmodelcs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\_ViewImports.cshtml"
using myblog.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ce0b6bc0edf9123cd9331ec389c00c70634504", @"/Views/Shared/Components/Navbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3ddeabc85284889c8bfbcb915c4a24a1d846411", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Navbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/blog/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Navbar\Default.cshtml"
  
	TempData["meta"] = Model.Meta;

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav class=\"menu\" id=\"scroll\">\r\n\t\t<div class=\"logo\"><h1>");
#nullable restore
#line 6 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Navbar\Default.cshtml"
                         Write(Model.Logo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1></div>
		<ul>
			<li><a href=""/home/"">Home</a></li>
			<li><a onclick=""iltac()"">Support</a></li>
			<li><a href=""/home/blog/"">Blog</a></li>
			<li><a href=""/home/About/"">About</a></li>

		</ul>
		<button class=""nav-buton"" onclick=""menuac()""><i class=""fa fa-bars""></i></button>
		");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ce0b6bc0edf9123cd9331ec389c00c706345045388", async() => {
                WriteLiteral("\r\n\t\t\t<button type=\"submit\"><i class=\"fa fa-search\"></i></button>\r\n\t\t\t<input type=\"text\" name=\"search\" value=\"Srch\">\r\n\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591