#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "211c9e2227843fda407b1b68b0a47c88bd5c03d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"211c9e2227843fda407b1b68b0a47c88bd5c03d1", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536de2c40635b39fb9607bc8e6355ead4c548b7f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <!-- ****** Quick View Modal Area Start ****** -->

        <!-- ****** Quick View Modal Area End ****** -->

        <section class=""shop_grid_area section_padding_100"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12 col-md-4 col-lg-3"">
                        <div class=""shop_sidebar_area"">
                           
                            <div class=""widget catagory mb-50"">
                                <!--  Side Nav  -->
                                <div class=""nav-side-menu"">
                                    <h6 class=""mb-0"">Catagories</h6>
                                    <div class=""menu-list"">
                                        <ul id=""menu-content2"" class=""menu-content collapse out"">
                                            <!-- Single Item -->
                                           
                                            <!-- Single Item -->
                                  ");
            WriteLiteral("         ");
#nullable restore
#line 27 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                      Write(await Html.PartialAsync("_Category",Model.MainCategories));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            <!-- Single Item -->
                                            
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""widget price mb-50 row"">
                                <h6 class=""widget-title mb-30"">Filter by Price</h6>
                                <div class=""widget-desc"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "211c9e2227843fda407b1b68b0a47c88bd5c03d16904", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label >Min Price</label>
                                        <input type=""number"" class=""form-control col-8"" name=""min_price"" placeholder=""Enter Price"">
                                    </div>
                                    <div class=""form-group"">
                                        <label >Max Price</label>
                                        <input type=""number"" class=""form-control col-8"" name=""max_price"" placeholder=""Enter Price"">
                                    </div>
                                    <button type=""submit"" class=""mt-3 p-2"" style=""
    color: #ff084e;
    border: 2px solid #ff084e;
    background-color: transparent;
"" href=""#"">Set Price</button></li>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <h4>");
#nullable restore
#line 54 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                           Write(ViewBag.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                            <div class=""widget color mb-70"">
                                <h6 class=""widget-title mb-30"">Filter by Color</h6>
                                <div class=""widget-desc"">
                                    <ul class=""d-flex justify-content-between"">
");
#nullable restore
#line 59 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                         foreach (var item in (List<Color>)ViewData["Colors"])
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("style", " style=\"", 3259, "\"", 3299, 2);
            WriteAttributeValue("", 3267, "background-color=", 3267, 17, true);
#nullable restore
#line 61 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
WriteAttributeValue("", 3284, item.ColorCode, 3284, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 3303, "\"", 3416, 1);
#nullable restore
#line 61 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
WriteAttributeValue("", 3310, ViewBag.Category==null?$"/Products?ColorId={item.Id}":$"/Products/{ViewBag.Category}?ColorId={item.Id}", 3310, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n");
#nullable restore
#line 62 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                            </div>

                        </div>
                    </div>

                    <div class=""col-12 col-md-8 col-lg-9"">
                        <div class=""shop_grid_product_area"">
                            <div class=""row"">
");
#nullable restore
#line 73 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                         if (Model.Product.Count > 0)
                        {
                            foreach (var item in Model.Product)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                           Write(await Html.PartialAsync("_Product",item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                                                         
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert-danger\">Ürün Yok</div>\r\n");
#nullable restore
#line 83 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                        </div>

                        <div class=""shop_pagination_area wow fadeInUp"" data-wow-delay=""1.1s"">
                            <nav aria-label=""Page navigation"">
                                <ul class=""pagination pagination-sm"">
");
#nullable restore
#line 90 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                    for (int i = 0; i < Model.Page.TotalPage(); i++)
                                    {
                                        if(!string.IsNullOrEmpty(Model.Page.CurrentCategory)){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <li");
            BeginWriteAttribute("class", " class=\"", 4849, "\"", 4911, 2);
            WriteAttributeValue("", 4857, "page-item", 4857, 9, true);
#nullable restore
#line 93 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 4866, Model.Page.CurrentPage==(i+1)?"active":"", 4867, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 4915, "\"", 4971, 4);
            WriteAttributeValue("", 4922, "/Products/", 4922, 10, true);
#nullable restore
#line 93 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
WriteAttributeValue("", 4932, Model.Page.CurrentCategory, 4932, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4959, "?page=", 4959, 6, true);
#nullable restore
#line 93 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
WriteAttributeValue("", 4965, i+1, 4965, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" href=\"#\">");
#nullable restore
#line 93 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                                                                                                                                                                                   Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 94 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                        }
                                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <li");
            BeginWriteAttribute("class", " class=\"", 5155, "\"", 5217, 2);
            WriteAttributeValue("", 5163, "page-item", 5163, 9, true);
#nullable restore
#line 96 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 5172, Model.Page.CurrentPage==(i+1)?"active":"", 5173, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 5221, "\"", 5277, 4);
            WriteAttributeValue("", 5228, "/Products/", 5228, 10, true);
#nullable restore
#line 96 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
WriteAttributeValue("", 5238, Model.Page.CurrentCategory, 5238, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5265, "?page=", 5265, 6, true);
#nullable restore
#line 96 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
WriteAttributeValue("", 5271, i+1, 5271, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" href=\"#\">");
#nullable restore
#line 96 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                                                                                                                                                                                   Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 97 "C:\Users\Mehmet Kelleli\Desktop\myblog\Fashion\Fashion\Views\Shop\List.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </nav>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
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
