#pragma checksum "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\Home\ITOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46908cd0bf46e0652b60be67a1f047da24a2b951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganizations), @"mvc.1.0.view", @"/Views/Home/ITOrganizations.cshtml")]
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
#line 1 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\_ViewImports.cshtml"
using ASP_CORE_3rd_HandsOn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\_ViewImports.cshtml"
using ASP_CORE_3rd_HandsOn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46908cd0bf46e0652b60be67a1f047da24a2b951", @"/Views/Home/ITOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b02b7273f47d67e7ff36e9c4cf85bbdcaafc682", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\Home\ITOrganizations.cshtml"
  
    ViewData["Title"] = "IT Organizations";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\Home\ITOrganizations.cshtml"
   
    List<string> list = new List<string>();
    list.Add("Microsoft www.microsoft.com");
    list.Add("CTS www.cognizant.com");
    list.Add("Google");
    list.Add("Amazon");
    list.Add("TCS");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n");
#nullable restore
#line 13 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\Home\ITOrganizations.cshtml"
     foreach(var org in list)
    {
        if (org.Equals("Amazon"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <b>");
#nullable restore
#line 17 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\Home\ITOrganizations.cshtml"
          Write(org);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 18 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\Home\ITOrganizations.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 21 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\Home\ITOrganizations.cshtml"
            Write(org);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 22 "C:\Users\Shaan Singh\source\repos\ASP_CORE_3rd_HandsOn\ASP_CORE_3rd_HandsOn\Views\Home\ITOrganizations.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
