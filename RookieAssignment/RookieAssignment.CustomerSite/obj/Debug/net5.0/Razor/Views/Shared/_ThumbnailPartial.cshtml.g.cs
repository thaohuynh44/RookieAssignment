#pragma checksum "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_ThumbnailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "841999b3109e9284ec3cb46505f1a0039e6a83de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbnailPartial), @"mvc.1.0.view", @"/Views/Shared/_ThumbnailPartial.cshtml")]
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
#line 1 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\_ViewImports.cshtml"
using RookieAssignment.CustomerSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\_ViewImports.cshtml"
using RookieAssignment.CustomerSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_ThumbnailPartial.cshtml"
using RookieAssignment.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841999b3109e9284ec3cb46505f1a0039e6a83de", @"/Views/Shared/_ThumbnailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a46546ef863f190e3f9adb22614b715ab18b8a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbnailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItemDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_ThumbnailPartial.cshtml"
 if(Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12\">\r\n        <div class=\"row\">\r\n            <h3 class=\"text-success\">");
#nullable restore
#line 8 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_ThumbnailPartial.cshtml"
                                Write(Model.FirstOrDefault().Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        \r\n");
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 25 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_ThumbnailPartial.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 941, "\"", 958, 1);
#nullable restore
#line 28 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_ThumbnailPartial.cshtml"
WriteAttributeValue("", 947, item.Image, 947, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""border-radius:5px; border: 1px solid #bbb9b9; width:250px;"" />
            <div class=""card-body"">
                <h4 class=""card-title"">Something</h4>
                <p class=""card-text"">Dddddddddddddddddddd</p>
            </div>
        </div>
");
#nullable restore
#line 34 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_ThumbnailPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_ThumbnailPartial.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItemDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
