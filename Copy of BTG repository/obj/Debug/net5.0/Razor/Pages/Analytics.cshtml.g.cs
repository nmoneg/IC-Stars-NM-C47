#pragma checksum "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Analytics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62fc5668d3e5ed69acb08e37268be476210b5b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RTWPortal.Pages.Pages_Analytics), @"mvc.1.0.razor-page", @"/Pages/Analytics.cshtml")]
namespace RTWPortal.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62fc5668d3e5ed69acb08e37268be476210b5b98", @"/Pages/Analytics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1d0af545b147158058eea4817665ae1374a2e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Analytics : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Analytics.cshtml"
  
    ViewData["Title"] = "Analytics";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">

    <div>
    <h2>Analytics Information</h2>
    </div>

    <a href=""https://azurewebsites.matomo.cloud/index.php?module=Widgetize&action=iframe&disableLink=0&widget=1&moduleToWidgetize=UserCountryMap&actionToWidgetize=visitorMap&idSite=1&period=day&date=yesterday&disableLink=1&widget=1""><button type=""button"" id=""purple"" class=""btn btn-primary btn-lg"" style= ""margin-top:30px"" >Visitor Map</button></a><br>

    <a href=""https://azurewebsites.matomo.cloud/index.php?module=Widgetize&action=iframe&forceView=1&viewDataTable=sparklines&disableLink=0&widget=1&moduleToWidgetize=VisitsSummary&actionToWidgetize=get&idSite=1&period=day&date=yesterday&disableLink=1&widget=1""><button type=""button"" id=""purple"" class=""btn btn-primary btn-lg"" style= ""margin-top:30px"" >Visits Overview</button></a><br>

    <a href=""https://azurewebsites.matomo.cloud/index.php?module=Widgetize&action=iframe&disableLink=0&widget=1&moduleToWidgetize=DevicesDetection&actionToWidgetize=getType&idSite=1&perio");
            WriteLiteral(@"d=day&date=yesterday&disableLink=1&widget=1""><button type=""button"" id=""purple"" class=""btn btn-primary btn-lg"" style= ""margin-top:30px"" >Device Overview</button></a><br>

    <a href=""https://azurewebsites.matomo.cloud/index.php?module=Widgetize&action=iframe&disableLink=0&widget=1&moduleToWidgetize=Insights&actionToWidgetize=getInsightsOverview&idSite=1&period=day&date=yesterday&disableLink=1&widget=1""><button type=""button"" id=""purple"" class=""btn btn-primary btn-lg"" style= ""margin-top:30px"" >Insights Overview</button></a><br>

    <br>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62fc5668d3e5ed69acb08e37268be476210b5b985024", async() => {
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnalyticsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnalyticsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnalyticsModel>)PageContext?.ViewData;
        public AnalyticsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
