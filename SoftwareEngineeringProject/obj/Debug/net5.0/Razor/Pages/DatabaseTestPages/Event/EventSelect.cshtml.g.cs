#pragma checksum "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "babab9197fe4789faf5c5c1a5bb6d62f4c393ccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SoftwareEngineeringProject.Pages.DatabaseTestPages.Event.Pages_DatabaseTestPages_Event_EventSelect), @"mvc.1.0.razor-page", @"/Pages/DatabaseTestPages/Event/EventSelect.cshtml")]
namespace SoftwareEngineeringProject.Pages.DatabaseTestPages.Event
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"babab9197fe4789faf5c5c1a5bb6d62f4c393ccd", @"/Pages/DatabaseTestPages/Event/EventSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af25912b62f228d4f303f6b8d52f6f8cb30275b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DatabaseTestPages_Event_EventSelect : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "babab9197fe4789faf5c5c1a5bb6d62f4c393ccd6102", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "babab9197fe4789faf5c5c1a5bb6d62f4c393ccd7375", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "babab9197fe4789faf5c5c1a5bb6d62f4c393ccd7633", async() => {
                    WriteLiteral(@"
        <div class=""container p-3"">
            <div class=""row pt-4"">
                <div class=""col-6"">
                    <h2 class=""text-primary"">Event Select</h2>
                </div>
            </div>

            <br /><br />
            <div class=""text-center"">
                <label class=""text-white fs-20"">Search By Event Name</label>
                <div class=""container-login100-form-btn"">
                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "babab9197fe4789faf5c5c1a5bb6d62f4c393ccd8340", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 26 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.searchText);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "babab9197fe4789faf5c5c1a5bb6d62f4c393ccd10345", async() => {
                        WriteLiteral("\n                        Search\n                    ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                </div>\n            </div>\n            <br /><br />\n");
#nullable restore
#line 33 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
             if (Model.eventList != null && Model.eventList.Count() > 0)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                <table class=""table table-bordered table-striped"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th class=""text-white fs-10"">
                                _ID
                            </th>
                            <th class=""text-white fs-10"">
                                EventName
                            </th>
                            <th class=""text-white fs-10"">
                                EventLocation
                            </th>
                            <th class=""text-white fs-10"">
                                EventDate
                            </th>
                            <th class=""text-white fs-10"">
                                NumberOfSlots
                            </th>
                            <th class=""text-white fs-10"">
                                AvailableSlots
                            </th>
                            <th class=""text-white fs-10"">
            ");
                    WriteLiteral(@"                    EventDescription
                            </th>
                            <th class=""text-white fs-10"">
                                Owner_ID
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 65 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                         foreach (Database.Event obj in Model.eventList)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <tr>\n                            <td class=\"text-white fs-10\" width=\"10%\">");
#nullable restore
#line 68 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                                Write(obj._id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                            <td class=\"text-white fs-10\" width=\"10%\">");
#nullable restore
#line 69 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                                Write(obj.EventName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                            <td class=\"text-white fs-10\" width=\"10%\">");
#nullable restore
#line 70 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                                Write(obj.EventLocation);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                            <td class=\"text-white fs-10\" width=\"10%\">");
#nullable restore
#line 71 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                                Write(obj.EventDate);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                            <td class=\"text-white fs-10\" width=\"10%\">");
#nullable restore
#line 72 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                                Write(obj.NumberOfSlots);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                            <td class=\"text-white fs-10\" width=\"10%\">");
#nullable restore
#line 73 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                                Write(obj.AvailableSlots);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                            <td class=\"text-white fs-10\" width=\"30%\">");
#nullable restore
#line 74 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                                Write(obj.EventDescription);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                            <td class=\"text-white fs-10\" width=\"10%\">");
#nullable restore
#line 75 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                                Write(obj.Owner_ID);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n\n\n\n\n\n                            <!--\n    <td class=\"text-center\">\n        <div class=\"w-75 btn-group\" role=\"group\">\n            <a asp-controller=\"Category\" asp-route-Id=\"");
#nullable restore
#line 84 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                  Write(obj);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\" asp-action=\"Edit\" class=\"btn btn-primary mx-2\">\n                <i class=\"fas fa-edit\"></i>\n            </a>\n            <a asp-controller=\"Category\" asp-route-Id=\"");
#nullable restore
#line 87 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                                                  Write(obj);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\" asp-action=\"Delete\" class=\"btn btn-danger mx-2\">\n                <i class=\"far fa-trash-alt\"></i>\n            </a>\n        </div>\n    </td>\n    -->\n                        </tr>\n");
#nullable restore
#line 94 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </tbody>\n                </table>\n");
#nullable restore
#line 97 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <p> No category exists.</p>\n");
#nullable restore
#line 101 "/Users/tyler/Desktop/softwareproject/SoftwareEngineeringProject/SoftwareEngineeringProject/Pages/DatabaseTestPages/Event/EventSelect.cshtml"
            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n            <br /><br />\n\n\n        </div>\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SoftwareEngineeringProject.Pages.DatabaseTestPages.Event.EventSelectModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SoftwareEngineeringProject.Pages.DatabaseTestPages.Event.EventSelectModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SoftwareEngineeringProject.Pages.DatabaseTestPages.Event.EventSelectModel>)PageContext?.ViewData;
        public SoftwareEngineeringProject.Pages.DatabaseTestPages.Event.EventSelectModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
