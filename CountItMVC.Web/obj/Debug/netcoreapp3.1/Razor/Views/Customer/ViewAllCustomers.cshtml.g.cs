#pragma checksum "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "974442cea91d0822ed01720161addbe73aa7c74f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ViewAllCustomers), @"mvc.1.0.view", @"/Views/Customer/ViewAllCustomers.cshtml")]
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
#line 1 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\_ViewImports.cshtml"
using CountItMVC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\_ViewImports.cshtml"
using CountItMVC.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"974442cea91d0822ed01720161addbe73aa7c74f", @"/Views/Customer/ViewAllCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4742bfdf8bd813f542bd75998ec562385dcde274", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ViewAllCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CountItMVC.Application.ViewModels.ListCustomerForListVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "searchString", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchString"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAllCustomers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
  
    ViewData["Title"] = "ViewAllActiveCustomers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewAllCustomers</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974442cea91d0822ed01720161addbe73aa7c74f5803", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974442cea91d0822ed01720161addbe73aa7c74f6970", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "974442cea91d0822ed01720161addbe73aa7c74f7263", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("type\"text\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 14 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\"/>\r\n    </div>\r\n    <div class=\"row\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 22 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                   Write(Html.DisplayNameFor(model => model.Customers[0].Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 25 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                   Write(Html.DisplayNameFor(model => model.Customers[0].Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                   Write(Html.DisplayNameFor(model => model.Customers[0].NationalId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                   Write(Html.DisplayNameFor(model => model.Customers[0].IsActive));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 37 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                 foreach (var item in Model.Customers)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NationalId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 54 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 55 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"row\">\r\n        <table>\r\n            <tr>\r\n");
#nullable restore
#line 65 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                 for (int i = 1; i < Math.Ceiling(Model.Count / (double)Model.PageSize) + 1; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>\r\n");
#nullable restore
#line 68 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                     if(i!=Model.CurrentPage)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\"", 2569, "\"", 2601, 3);
                WriteAttributeValue("", 2576, "javascript:PagerClick(", 2576, 22, true);
#nullable restore
#line 70 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
WriteAttributeValue("", 2598, i, 2598, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2600, ")", 2600, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 70 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 71 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span>");
#nullable restore
#line 74 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                     Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 75 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </td>\r\n");
#nullable restore
#line 77 "D:\VisualStudioProjects\GitHub\CountItMVC.Web\CountItMVC.Web\Views\Customer\ViewAllCustomers.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n        </table>\r\n        <input type=\"hidden\" name=\"pageNo\" id=\"pageNo\"/>\r\n        <input type=\"hidden\" name=\"pageSize\" id=\"pageSize\" value=\"2\"/> \r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    function PagerClick(ViewAllCustomers) {\r\n        document.getElementById(\"pageNo\").value = ViewAllCustomers;\r\n        document.forms[0].submit();\r\n    }\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountItMVC.Application.ViewModels.ListCustomerForListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
