#pragma checksum "/Users/efekanbicer/Projects/gitrepo/HepsiSurada-MVC-Project/HepsiSuradav2/Areas/Admin/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4130a21677542c5dd37930f08180259b9ab086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4130a21677542c5dd37930f08180259b9ab086", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/efekanbicer/Projects/gitrepo/HepsiSurada-MVC-Project/HepsiSuradav2/Areas/Admin/Views/Home/Index.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        ");
#nullable restore
#line 5 "/Users/efekanbicer/Projects/gitrepo/HepsiSurada-MVC-Project/HepsiSuradav2/Areas/Admin/Views/Home/Index.cshtml"
   Write(await Component.InvokeAsync("InfoBoxes", new { bgColorClassName = "bg-info"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 6 "/Users/efekanbicer/Projects/gitrepo/HepsiSurada-MVC-Project/HepsiSuradav2/Areas/Admin/Views/Home/Index.cshtml"
   Write(await Component.InvokeAsync("InfoBoxes", new { bgColorClassName = "bg-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 7 "/Users/efekanbicer/Projects/gitrepo/HepsiSurada-MVC-Project/HepsiSuradav2/Areas/Admin/Views/Home/Index.cshtml"
   Write(await Component.InvokeAsync("InfoBoxes", new { bgColorClassName = "bg-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 8 "/Users/efekanbicer/Projects/gitrepo/HepsiSurada-MVC-Project/HepsiSuradav2/Areas/Admin/Views/Home/Index.cshtml"
   Write(await Component.InvokeAsync("InfoBoxes", new { bgColorClassName = "bg-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    </div>\r\n\r\n    <h1>ADMİN SAYFASINA HOŞGELDİNİZ SAYIN ");
#nullable restore
#line 13 "/Users/efekanbicer/Projects/gitrepo/HepsiSurada-MVC-Project/HepsiSuradav2/Areas/Admin/Views/Home/Index.cshtml"
                                     Write(ViewBag.LoggedInAdminFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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