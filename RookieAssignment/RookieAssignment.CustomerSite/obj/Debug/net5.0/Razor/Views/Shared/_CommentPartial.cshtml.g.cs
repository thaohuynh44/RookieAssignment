#pragma checksum "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_CommentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8848018b7e2885334fd244abf938d6099aa742ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentPartial), @"mvc.1.0.view", @"/Views/Shared/_CommentPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8848018b7e2885334fd244abf938d6099aa742ea", @"/Views/Shared/_CommentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a46546ef863f190e3f9adb22614b715ab18b8a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RookieAssignment.Shared.DTOs.MenuItemCommentDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row border-dark my-3 mx-0\" style=\"border-radius:5px; border:solid;\">\r\n    <div class=\"col-md-8 col-sm-12\">\r\n        <div><i>");
#nullable restore
#line 26 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_CommentPartial.cshtml"
           Write(Model.PublishedDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></div>\r\n        <div>");
#nullable restore
#line 27 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_CommentPartial.cshtml"
        Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"col-md-4 col-sm-12 d-flex align-items-center justify-content-end\" style=\"color:#FDCC0D\">\r\n");
#nullable restore
#line 30 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_CommentPartial.cshtml"
         for (int i = 0; i < Model.Rating; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"fas fa-star\"></span>\r\n");
#nullable restore
#line 33 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_CommentPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_CommentPartial.cshtml"
         for (int i = Model.Rating; i < 5; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"far fa-star\"></span>\r\n");
#nullable restore
#line 37 "C:\Users\Surface\OneDrive\Desktop\RookieAssignment\RookieAssignment\RookieAssignment.CustomerSite\Views\Shared\_CommentPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RookieAssignment.Shared.DTOs.MenuItemCommentDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
