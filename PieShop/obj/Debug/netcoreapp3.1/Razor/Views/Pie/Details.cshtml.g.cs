#pragma checksum "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8218c10b4b14666c11e760c7a5d5d728d2beaab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_Details), @"mvc.1.0.view", @"/Views/Pie/Details.cshtml")]
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
#line 1 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\_ViewImports.cshtml"
using PieShop.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\_ViewImports.cshtml"
using PieShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8218c10b4b14666c11e760c7a5d5d728d2beaab8", @"/Views/Pie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68cd193ad16521fe0ed8d186db18a4b5b0786e2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PieShop.Models.Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            BeginWriteAttribute("alt", " alt=\"", 87, "\"", 104, 1);
#nullable restore
#line 6 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml"
WriteAttributeValue("", 93, Model.Name, 93, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 105, "\"", 126, 1);
#nullable restore
#line 6 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml"
WriteAttributeValue("", 111, Model.ImageUrl, 111, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
#nullable restore
#line 8 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
#nullable restore
#line 10 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </h3>\r\n        <h4>");
#nullable restore
#line 12 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 13 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n     <div class=\"addToCart\">\r\n        <p class=\"button\">\r\n            <a class=\"btn btn-primary\">\r\n                asp-controller = \"ShoppingCart\"\r\n                asp-action=\"AddToShoppingCart\"\r\n                asp-route-pieId=\"");
#nullable restore
#line 20 "C:\Users\wenhua.FAREAST\PieShop\PieShop\Views\Pie\Details.cshtml"
                            Write(Model.PieId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" Add to cart\r\n            </a>\r\n        </p>\r\n        <div>\r\n  </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PieShop.Models.Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
