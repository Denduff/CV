#pragma checksum "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a54473c2fa1647138cbcacc342c29bbafcec5d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ActiveStudents), @"mvc.1.0.view", @"/Views/Student/ActiveStudents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a54473c2fa1647138cbcacc342c29bbafcec5d6", @"/Views/Student/ActiveStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae639f395de502fbde10878840c5e0b8f8efe39", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_ActiveStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SayItWebsiteNet5.Models.Student>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a54473c2fa1647138cbcacc342c29bbafcec5d63983", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a54473c2fa1647138cbcacc342c29bbafcec5d65042", async() => {
                WriteLiteral("\r\n\r\n    <!-- make shit look neat-->\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
               Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
               Write(Html.DisplayNameFor(model => model.EnrollmentCreated));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
               Write(Html.DisplayNameFor(model => model.DaysTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
               Write(Html.DisplayNameFor(model => model.AbsentDaysTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
               Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a54473c2fa1647138cbcacc342c29bbafcec5d67872", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.Name));

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
#line 43 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                                                     WriteLiteral(item._Id);

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
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EnrollmentCreated));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DaysTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AbsentDaysTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 58 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                          
                            string activity = item.Active ? "Aktiv" : "Inaktiv";
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>\r\n                            ");
#nullable restore
#line 62 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                       Write(activity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 67 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                         if (User.IsInRole("Admin"))
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button class=\"btn-primary\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2285, "\"", 2302, 1);
#nullable restore
#line 70 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
WriteAttributeValue("", 2293, item._Id, 2293, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"myFunction(this)\">Skift status</button>\r\n");
#nullable restore
#line 71 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<script>\r\n    function myFunction(obj) {\r\n        let text = \"Ønsker du at gøre eleven Inaktiv? \\n OK for at bekræfte.\";\r\n        if (confirm(text) == true)\r\n            window.location.href = \'");
#nullable restore
#line 86 "C:\Users\Duff\Desktop\SayIT\SayItWebsiteNet5\Views\Student\ActiveStudents.cshtml"
                               Write(Url.Action("ChangeActivity","Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\' + obj.value;\r\n\r\n    }\r\n</script>\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SayItWebsiteNet5.Models.Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
