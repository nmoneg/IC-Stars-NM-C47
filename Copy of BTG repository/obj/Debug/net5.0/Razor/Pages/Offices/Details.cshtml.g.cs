#pragma checksum "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f213fedb864ed74282e7af6bcad443b5e18ca0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RTWPortal.Pages.Offices.Pages_Offices_Details), @"mvc.1.0.razor-page", @"/Pages/Offices/Details.cshtml")]
namespace RTWPortal.Pages.Offices
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
#line 1 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\_ViewImports.cshtml"
using RTWPortal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f213fedb864ed74282e7af6bcad443b5e18ca0f", @"/Pages/Offices/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1d0af545b147158058eea4817665ae1374a2e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Offices_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
        <h1>Office Details</h1>   
</div>

    <div class=""text-center"" style=""margin-top:20px"">

        <div class=""container"">
            <div class=""row"">
                <div class=""col-6 col-md-4"""">
                    <ul style=""list-style-type:none;"">
                        <li><h3>");
#nullable restore
#line 17 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Office.Office_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></li>\r\n                        <li><h6>");
#nullable restore
#line 18 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Office.Location_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><br><h5>");
#nullable restore
#line 19 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Office.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></li>\r\n                        <li><br><strong>Region:</strong>");
#nullable restore
#line 20 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Office.Market_Unit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><br><strong>Address:</strong><br>");
#nullable restore
#line 21 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                        Write(Html.DisplayFor(model => model.Office.Street_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"col-6 col-md-4\"\">\r\n                    <ul style=\"list-style-type:none;\">\r\n                        <li><strong>Office Services:</strong> ");
#nullable restore
#line 26 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.Office.Services));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Visitors Allowed:</strong> ");
#nullable restore
#line 27 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Office.Visitors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Temperature Checks:</strong> ");
#nullable restore
#line 28 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.Office.Temp_Checks));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Special Considerations:</strong> ");
#nullable restore
#line 29 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                                Write(Html.DisplayFor(model => model.Office.Special_Considerations));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Special Consideration Details:</strong> ");
#nullable restore
#line 30 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                                       Write(Html.DisplayFor(model => model.Office.Special_Consideration_Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Tech Support:</strong> ");
#nullable restore
#line 31 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                      Write(Html.DisplayFor(model => model.Office.Tech_Support));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Dress Code:</strong> ");
#nullable restore
#line 32 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Office.Dress_Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Additional Information:</strong> ");
#nullable restore
#line 33 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Offices\Details.cshtml"
                                                                Write(Html.DisplayFor(model => model.Office.Additional_Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
            WriteLiteral("                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f213fedb864ed74282e7af6bcad443b5e18ca0f8921", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>     \r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RTWPortal.Pages.Offices.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RTWPortal.Pages.Offices.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RTWPortal.Pages.Offices.DetailsModel>)PageContext?.ViewData;
        public RTWPortal.Pages.Offices.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
