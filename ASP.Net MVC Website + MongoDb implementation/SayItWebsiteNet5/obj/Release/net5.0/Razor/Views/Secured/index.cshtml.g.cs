#pragma checksum "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0301345e50dce51e213e9a4cab286f276b3f1d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Secured_index), @"mvc.1.0.view", @"/Views/Secured/index.cshtml")]
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
#line 1 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\_ViewImports.cshtml"
using SayItWebsiteNet5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\_ViewImports.cshtml"
using SayItWebsiteNet5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\_ViewImports.cshtml"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0301345e50dce51e213e9a4cab286f276b3f1d3", @"/Views/Secured/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae639f395de502fbde10878840c5e0b8f8efe39", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Secured_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
            WriteLiteral("\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 12 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
     foreach ( var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 14 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 15 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n");
#nullable restore
#line 16 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 22 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
     foreach(var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 24 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
       Write(prop.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 25 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
       Write(prop.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n");
#nullable restore
#line 26 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Secured\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
