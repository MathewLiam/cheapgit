#pragma checksum "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb549ac45bf2a0ff0d1a7118a1693b17668c0a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_CategoryPage), @"mvc.1.0.view", @"/Views/Cms/CategoryPage.cshtml")]
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
#line 1 "D:\cheapgit\cheapgit.web\Views\_ViewImports.cshtml"
using Piranha.AspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\cheapgit\cheapgit.web\Views\_ViewImports.cshtml"
using cheapgit.web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb549ac45bf2a0ff0d1a7118a1693b17668c0a1", @"/Views/Cms/CategoryPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecedb8a697133941fca59bb61a8eec2605ff9bb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_CategoryPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cheapgit.web.Models.Pages.CategoryArchive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n    <div class=\"container text-center\">\r\n        <h1>");
#nullable restore
#line 8 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n</header>\r\n<main>\r\n    <div class=\"container\">\r\n        <div class=\"card-columns\">\r\n");
#nullable restore
#line 14 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
             foreach(var cat in Model.Archive.Posts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 18rem;\">\r\n");
#nullable restore
#line 17 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
                 if (cat.PrimaryImage.HasValue)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 555, 1);
#nullable restore
#line 19 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
WriteAttributeValue("", 541, cat.Permalink, 541, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img class=\"rounded mb-3\"");
            BeginWriteAttribute("src", " src=\"", 608, "\"", 644, 1);
#nullable restore
#line 20 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
WriteAttributeValue("", 614, Url.Content(cat.PrimaryImage), 614, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 645, "\"", 682, 1);
#nullable restore
#line 20 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
WriteAttributeValue("", 651, cat.PrimaryImage.Media.AltText, 651, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n");
#nullable restore
#line 22 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-body\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 794, "\"", 815, 1);
#nullable restore
#line 24 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
WriteAttributeValue("", 801, cat.Permalink, 801, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\"><h5 class=\"card-title\">");
#nullable restore
#line 24 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
                                                                                 Write(cat.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></a>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 25 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
                                    Write(cat.OgDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "D:\cheapgit\cheapgit.web\Views\Cms\CategoryPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        \r\n    </div> \r\n</main>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cheapgit.web.Models.Pages.CategoryArchive> Html { get; private set; }
    }
}
#pragma warning restore 1591