#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Categories\Default.Cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03b00c9ffe3c9e00e1a63937894370a9fcc57a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/Default.Cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03b00c9ffe3c9e00e1a63937894370a9fcc57a70", @"/Views/Shared/Components/Categories/Default.Cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3ddeabc85284889c8bfbcb915c4a24a1d846411", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Categories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"sidebar-content\">\r\n \t\t\t<h1>Categories</h1>\r\n \t\t\t<span class=\"sidebar-hr\"></span>\r\n \t\t\t<ul>\r\n");
#nullable restore
#line 6 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Categories\Default.Cshtml"
                  foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 183, "\"", 209, 2);
            WriteAttributeValue("", 190, "/home/blog/", 190, 11, true);
#nullable restore
#line 8 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Categories\Default.Cshtml"
WriteAttributeValue("", 201, item.Id, 201, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Categories\Default.Cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 9 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Categories\Default.Cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" \t\t\t</ul>\r\n </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
