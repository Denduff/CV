#pragma checksum "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e38434edc660a6291cf98d1a3f75e414c3cb69a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SIEvents_DetailedEvent), @"mvc.1.0.view", @"/Views/SIEvents/DetailedEvent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38434edc660a6291cf98d1a3f75e414c3cb69a2", @"/Views/SIEvents/DetailedEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae639f395de502fbde10878840c5e0b8f8efe39", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SIEvents_DetailedEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SayItWebsiteNet5.Models.SIEvents>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
  
    ViewData["Title"] = "Event Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Event Information</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Creator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n       \r\n                <p> ");
#nullable restore
#line 41 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
               Write(ViewBag.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          \r\n\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    <p>Deltagere</p>\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 57 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
             foreach (var person in Model.Participants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
                   Write(Html.DisplayFor(modelItem => person.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
                                                              Write(Html.DisplayFor(modelItem => person.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\SIEvents\DetailedEvent.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e38434edc660a6291cf98d1a3f75e414c3cb69a28684", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SayItWebsiteNet5.Models.SIEvents> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591