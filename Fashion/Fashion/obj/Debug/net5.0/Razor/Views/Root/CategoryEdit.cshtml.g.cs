#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8d38f2cd9ba305f3df8a57768d489b4dfb76e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Root_CategoryEdit), @"mvc.1.0.view", @"/Views/Root/CategoryEdit.cshtml")]
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
#line 1 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\_ViewImports.cshtml"
using Fashion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\_ViewImports.cshtml"
using Fashion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\_ViewImports.cshtml"
using Fashion.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\_ViewImports.cshtml"
using Fashion.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\_ViewImports.cshtml"
using Fashion.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8d38f2cd9ba305f3df8a57768d489b4dfb76e6", @"/Views/Root/CategoryEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536de2c40635b39fb9607bc8e6355ead4c548b7f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Root_CategoryEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "MainCategoryId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Root", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "root", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "categoryproductdelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
  
    ViewData["Title"] = "ProductAdd";
    Layout = "~/Views/Shared/_LayoutRoot.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-12"">
    <div class=""card card-primary mt-5 ml-3"">
              <div class=""card-header"">
                <h3 class=""card-title"">Product Add</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <div class=""row"">
                  <div class=""col-md-3""></div>
                  <div class=""row"">
                      <div class=""col-md-6"">
                          <div class=""col-md-9"">
                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8d38f2cd9ba305f3df8a57768d489b4dfb76e67888", async() => {
                WriteLiteral("\r\n                  <div class=\"card-body\">\r\n                  <div class=\"form-group\">\r\n                    <label>Name</label>\r\n                    <input name=\"Name\" class=\"form-control\"");
                BeginWriteAttribute("Value", "  Value=\"", 888, "\"", 917, 1);
#nullable restore
#line 22 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
WriteAttributeValue("", 897, Model.Category.Name, 897, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                  </div>\r\n                  <div class=\"form-group\">\r\n                    <label>Url</label>\r\n                    <input name=\"Url\" class=\"form-control\"");
                BeginWriteAttribute("Value", "  Value=\"", 1089, "\"", 1117, 1);
#nullable restore
#line 26 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
WriteAttributeValue("", 1098, Model.Category.Url, 1098, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                  </div>\r\n                  <div class=\"form-group\">\r\n                    <label>Main Category</label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8d38f2cd9ba305f3df8a57768d489b4dfb76e69464", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 30 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Liste;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                  </div>
                  
                 
                  </div>
                <!-- /.card-body -->

                <div class=""card-footer"">
                  <button type=""submit"" class=""btn btn-primary"">Edit Main Category</button>
                </div>
              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                  </div>
                      </div>
                    <div class=""col-md-6"">
                        <table class=""table table-head-fixed text-nowrap"">
                  <thead>
                    <tr>
                      <th>Id</th>
                      <th>Pictures</th>
                      <th>Name</th>
                      <th>Stock</th>
                      <th>Is Home</th>
                      <th>Price</th>
                      <th></th>
                    </tr>
                  </thead>
                  <tbody>
");
#nullable restore
#line 57 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                     foreach (var item in Model.Product)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                      <td>");
#nullable restore
#line 60 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fd8d38f2cd9ba305f3df8a57768d489b4dfb76e614265", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2420, "~/img/product-img/", 2420, 18, true);
#nullable restore
#line 61 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
AddHtmlAttributeValue("", 2438, item.ImgUrl, 2438, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                      <td>");
#nullable restore
#line 62 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td>");
#nullable restore
#line 63 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                     Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                                     if (item.IsHome)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <span class=\"tag bg-success\">Approved</span>                                   \r\n");
#nullable restore
#line 67 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                                    }
                                    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"tag bg-danger\"> Not Approved</span>\r\n");
#nullable restore
#line 70 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8d38f2cd9ba305f3df8a57768d489b4dfb76e617870", async() => {
                WriteLiteral("<button class=\"btn btn-success\">Edit</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                                                                                         WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8d38f2cd9ba305f3df8a57768d489b4dfb76e620363", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 3451, "\"", 3467, 1);
#nullable restore
#line 76 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
WriteAttributeValue("", 3459, item.Id, 3459, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 3549, "\"", 3575, 1);
#nullable restore
#line 77 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
WriteAttributeValue("", 3557, Model.Category.Id, 3557, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                        <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n                                   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                    </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Root\CategoryEdit.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </tbody>\r\n                </table>\r\n                    </d>\r\n                  </div>\r\n              \r\n              </div>\r\n            </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
