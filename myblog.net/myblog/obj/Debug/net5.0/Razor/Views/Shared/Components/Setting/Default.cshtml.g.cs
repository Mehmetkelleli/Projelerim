#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Setting\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01b1af8eb936442186ee0e426aeac76525b72d3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Setting_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Setting/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b1af8eb936442186ee0e426aeac76525b72d3e", @"/Views/Shared/Components/Setting/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3ddeabc85284889c8bfbcb915c4a24a1d846411", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Setting_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 37, "\"", 58, 1);
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Setting\Default.cshtml"
WriteAttributeValue("", 47, Model.Meta, 47, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<meta name=\"author\"");
            BeginWriteAttribute("content", " content=\"", 81, "\"", 106, 1);
#nullable restore
#line 3 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog.net\myblog\Views\Shared\Components\Setting\Default.cshtml"
WriteAttributeValue("", 91, ViewBag.author, 91, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
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
