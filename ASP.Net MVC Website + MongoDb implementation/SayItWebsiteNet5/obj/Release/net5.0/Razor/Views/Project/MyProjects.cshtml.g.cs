#pragma checksum "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e5f59a33b3850ec5cd9ad5e139b81458a44466c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_MyProjects), @"mvc.1.0.view", @"/Views/Project/MyProjects.cshtml")]
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
#line 1 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e5f59a33b3850ec5cd9ad5e139b81458a44466c", @"/Views/Project/MyProjects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae639f395de502fbde10878840c5e0b8f8efe39", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Project_MyProjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SayItWebsiteNet5.Models.Project>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnSubscribeProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
  
    ViewData["Title"] = "MyProjects";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e5f59a33b3850ec5cd9ad5e139b81458a44466c5778", async() => {
                WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                                             WriteLiteral(item.Id.ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                         if (User?.Identity.IsAuthenticated ?? false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e5f59a33b3850ec5cd9ad5e139b81458a44466c8895", async() => {
                WriteLiteral("Afmeld");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <span>Log på for tilmelde</span>\r\n                                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1298, "\"", 1354, 3);
            WriteAttributeValue("", 1308, "location.href=\'", 1308, 15, true);
#nullable restore
#line 40 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
WriteAttributeValue("", 1323, Url.Action("Login","Account"), 1323, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1353, "\'", 1353, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Login</button>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 43 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                         if (User?.Identity.IsAuthenticated ?? false)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                             if (User.IsInRole("Admin") || item.Owner._Id.ToString() == _userManager.GetUserId(User))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"text-danger\"> ");
#nullable restore
#line 48 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                                                      Write(Html.ValidationMessage("DeleteProjectError"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                <button class=\"btn btn-primary\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 1877, "\"", 1893, 1);
#nullable restore
#line 49 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
WriteAttributeValue("", 1885, item.Id, 1885, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"myFunction(this)\">Slet</button>\r\n");
#nullable restore
#line 50 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Project\MyProjects.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> _userManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SayItWebsiteNet5.Models.Project>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
