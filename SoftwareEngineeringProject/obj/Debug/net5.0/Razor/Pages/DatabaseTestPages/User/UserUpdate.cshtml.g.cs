#pragma checksum "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f3160fa642f254f3f8ca0f43a4fbf221b49188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SoftwareEngineeringProject.Pages.DatabaseTestPages.User.Pages_DatabaseTestPages_User_UserUpdate), @"mvc.1.0.razor-page", @"/Pages/DatabaseTestPages/User/UserUpdate.cshtml")]
namespace SoftwareEngineeringProject.Pages.DatabaseTestPages.User
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
#line 1 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/_ViewImports.cshtml"
using SoftwareEngineeringProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f3160fa642f254f3f8ca0f43a4fbf221b49188", @"/Pages/DatabaseTestPages/User/UserUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af25912b62f228d4f303f6b8d52f6f8cb30275b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DatabaseTestPages_User_UserUpdate : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/DatabaseTestPages/User/UserUpdateHelper", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f3160fa642f254f3f8ca0f43a4fbf221b491884344", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/main.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/myEdit.css"">


");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f3160fa642f254f3f8ca0f43a4fbf221b491885617", async() => {
                WriteLiteral("\n");
                WriteLiteral("    <div class=\"container p-3\">\n        <div class=\"row pt-4\">\n            <div class=\"col-6\">\n                <h2 class=\"text-primary\">Registration Delete</h2>\n            </div>\n        </div>\n        <br /><br />\n");
#nullable restore
#line 22 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
         if (Model.userList != null && Model.userList.Count() > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table class=""table table-bordered table-striped"" style=""width:100%"">
                <thead>
                    <tr>
                        <th class=""text-white"">
                            _ID
                        </th>
                        <th class=""text-white"">
                            Username
                        </th>
                        <th class=""text-white"">
                            Password
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 40 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
                     foreach (Database.UserInfoLogin obj in Model.userList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td class=\"text-white\" width=\"40%\">");
#nullable restore
#line 43 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
                                                          Write(obj._id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td class=\"text-white\" width=\"30%\">");
#nullable restore
#line 44 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
                                                          Write(obj.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td class=\"text-white\" width=\"30%\">");
#nullable restore
#line 45 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
                                                          Write(obj.Password);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td class=\"text-center\">\n                                <div class=\"w-75 btn-group\" role=\"group\">\n\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f3160fa642f254f3f8ca0f43a4fbf221b491888794", async() => {
                    WriteLiteral("\n                                        <i class=\"fa fa-pencil text-black-important\" aria-hidden=\"true\"></i>\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
                                                                                                                                      WriteLiteral(obj._id);

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
                WriteLiteral(@"
                                </div>
                            </td>
                            <!--
                            <td class=""text-center"">
                                <div class=""w-75 btn-group"" role=""group"">
                                    <a asp-controller=""Category"" asp-route-Id=""");
#nullable restore
#line 57 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
                                                                          Write(obj);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" asp-action=\"Edit\" class=\"btn btn-primary mx-2\">\n                                        <i class=\"fas fa-edit\"></i>\n                                    </a>\n                                    <a asp-controller=\"Category\" asp-route-Id=\"");
#nullable restore
#line 60 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
                                                                          Write(obj);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" asp-action=""Delete"" class=""btn btn-danger mx-2"">
                                        <i class=""far fa-trash-alt""></i>
                                    </a>
                                </div>
                            </td>
                            -->
                        </tr>
");
#nullable restore
#line 67 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\n            </table>\n");
#nullable restore
#line 70 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p> No category exists.</p>\n");
#nullable restore
#line 74 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/User/UserUpdate.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br /><br />\n\n\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SoftwareEngineeringProject.Pages.DatabaseTestPages.User.UserUpdateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SoftwareEngineeringProject.Pages.DatabaseTestPages.User.UserUpdateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SoftwareEngineeringProject.Pages.DatabaseTestPages.User.UserUpdateModel>)PageContext?.ViewData;
        public SoftwareEngineeringProject.Pages.DatabaseTestPages.User.UserUpdateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
