#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1f1d5df11571a90e24fb38d5482b7e2eab4f46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1f1d5df11571a90e24fb38d5482b7e2eab4f46", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3ddeabc85284889c8bfbcb915c4a24a1d846411", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cv>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Home\About.cshtml"
  
    ViewBag.title = "About";
    Layout = "~/Views/Shared/_BlogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<style type=""text/css"">

		.kod{
			width: 100%;
			text-align:left;
		}
		.sol{
			width: 80%!important;
			margin: 0 auto!important;

		}
		
		.card{
			box-shadow: 0 0 0 0!important;
			text-align: justify;
			
		}
		.card>p{
			margin-top: 50px;
		}
	</style>
	<main class=""web-main"" style=""margin-top: 50px;"">
 	<div class=""sol"">
 	<h1>");
#nullable restore
#line 29 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Home\About.cshtml"
    Write(Model.CvTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n \t\t<div class=\"card\"");
            BeginWriteAttribute("style", " style=\"", 505, "\"", 513, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n \t\t\t");
#nullable restore
#line 31 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Home\About.cshtml"
        Write(Html.Raw(@Model.CvContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \t\t</div>\r\n\r\n \t</div>\r\n\r\n\r\n\r\n\r\n </main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cv> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
