#pragma checksum "C:\Users\BukolaThompson\Documents\projects\ASP.NET MVC Project\DutchTreat\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c0ebb0883eecc564b523a18efe35400c619810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
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
#line 1 "C:\Users\BukolaThompson\Documents\projects\ASP.NET MVC Project\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BukolaThompson\Documents\projects\ASP.NET MVC Project\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BukolaThompson\Documents\projects\ASP.NET MVC Project\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c0ebb0883eecc564b523a18efe35400c619810", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816c0a811a42587a83c518295c09524e2b825d70", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Shop</h1>\r\n<p>Count: ");
#nullable restore
#line 6 "C:\Users\BukolaThompson\Documents\projects\ASP.NET MVC Project\DutchTreat\Views\App\Shop.cshtml"
     Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\BukolaThompson\Documents\projects\ASP.NET MVC Project\DutchTreat\Views\App\Shop.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 10 "C:\Users\BukolaThompson\Documents\projects\ASP.NET MVC Project\DutchTreat\Views\App\Shop.cshtml"
   Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\Users\BukolaThompson\Documents\projects\ASP.NET MVC Project\DutchTreat\Views\App\Shop.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
