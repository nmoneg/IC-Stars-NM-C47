#pragma checksum "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d39aba9f4cd9c116aadf8a79130cc6ce970fbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RTWPortal.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d39aba9f4cd9c116aadf8a79130cc6ce970fbb", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1d0af545b147158058eea4817665ae1374a2e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\NicolettaMonegain\Documents\GitHub\btgsolutions\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"" style=""margin-top:30px"">
    <h2>Welcome Back!</h2>
</div>

<div id=""Home"" class=""container"" style=""margin-top:30px"">
                <div class= ""text-center"">
                    <dt><strong>Home Office</strong><br></dt>
                    <dd>
                        <br><p>Chicago Innovation Lab</p>
                    </dd>
                
                    <dt><strong>Status</strong></dt>
                    <dd>
                        <br><p>&nbsp;By Invitation Only</p>
                    </dd>
                    <small class=""form-text text-muted"">
                        Select any location by using the <strong>Offices</strong> option from the navigation bar.<br>
                        View your home office information with the <strong>Home Office</strong> button below.
                    </small>
                    <a href=""/Details""><button type=""button"" id=""purple"" class=""btn btn-primary btn-lg"" style= ""margin-top:30px"" >Home Office</button><");
            WriteLiteral("/a>               \r\n                 </div>    \r\n</div>\r\n        \r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
