#pragma checksum "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45e22803f107a135e810a5ea8c95d736f7fe58a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Day_DayDetail), @"mvc.1.0.view", @"/Views/Day/DayDetail.cshtml")]
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
#line 1 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\_ViewImports.cshtml"
using CountItMVC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\_ViewImports.cshtml"
using CountItMVC.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e22803f107a135e810a5ea8c95d736f7fe58a2", @"/Views/Day/DayDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd16f6babb94a7eb59480e3e808c88476418b64f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Day_DayDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CountItMVC.Application.ViewModels.DayDetailVm>
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
#line 3 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
  
    ViewData["Title"] = "DayDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DayDetail</h1>\r\n\r\n<div>\r\n    <h4>DayDetailVm</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalKcal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayFor(model => model.TotalKcal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalFat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayFor(model => model.TotalFat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalProtein));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayFor(model => model.TotalProtein));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalCarbs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayFor(model => model.TotalCarbs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalWeightInGram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayFor(model => model.TotalWeightInGram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 69 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 72 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 75 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].TotalKcal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 78 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].TotalFat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 81 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].TotalProtein));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 84 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].TotalCarb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 87 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].TotalWeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 90 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].IsVisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 93 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.mealList[0].DayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 99 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
             foreach (var item in Model.mealList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 103 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 106 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 109 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalKcal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 112 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalFat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 115 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalProtein));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 118 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalCarb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 121 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalWeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 124 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsVisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 127 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 130 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.ActionLink("Edit", actionName: "EditMeal", controllerName: "Meal", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 131 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.ActionLink("Details", actionName: "MealDetail", controllerName: "Meal", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 132 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.ActionLink("Delete", "DeleteMeal", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 133 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
                   Write(Html.ActionLink("AddItemToMeal", actionName: "AddItemToMeal", controllerName: "ItemInMeal", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 137 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 142 "C:\Projects\dza\CountUt.Web\CountItMVC.Web\Views\Day\DayDetail.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e22803f107a135e810a5ea8c95d736f7fe58a217256", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountItMVC.Application.ViewModels.DayDetailVm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
