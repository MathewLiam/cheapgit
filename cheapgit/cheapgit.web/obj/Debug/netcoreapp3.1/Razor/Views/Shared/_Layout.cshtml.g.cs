#pragma checksum "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e592fee62ba5cbfebbf46dbad2563a1c797f7b93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 16 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
using cheapgit.web.Models.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e592fee62ba5cbfebbf46dbad2563a1c797f7b93", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecedb8a697133941fca59bb61a8eec2605ff9bb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/assets/css/style.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/productexplorer/main.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e592fee62ba5cbfebbf46dbad2563a1c797f7b935819", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <title>CheapGit - ");
#nullable restore
#line 6 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=Lato:wght@300;400&family=Raleway:wght@700&display=swap"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e592fee62ba5cbfebbf46dbad2563a1c797f7b936817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 9 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e592fee62ba5cbfebbf46dbad2563a1c797f7b938816", async() => {
                    WriteLiteral("\r\n        <script src=\"https://unpkg.com/react@17/umd/react.development.js\" crossorigin></script>\r\n        <script src=\"https://unpkg.com/react-dom@17/umd/react-dom.development.js\" crossorigin></script>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
Write(RenderSection("head", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e592fee62ba5cbfebbf46dbad2563a1c797f7b9311209", async() => {
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-md navbar-light fixed-top\">\r\n        <div class=\"container\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e592fee62ba5cbfebbf46dbad2563a1c797f7b9311587", async() => {
                    WriteLiteral("CheapGit.com");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarsExampleDefault"" aria-controls=""navbarsExampleDefault"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarsExampleDefault"">
                <ul class=""navbar-nav ml-auto"">
");
#nullable restore
#line 27 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
                     foreach (var item in WebApp.Site.Sitemap.Where(m => m.PageTypeName == "Category Page" && !m.IsHidden))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"nav-item dropdown\">\r\n                            <a class=\"nav-link dropdown-toggle\"");
                BeginWriteAttribute("href", " href=\"", 1861, "\"", 1885, 1);
#nullable restore
#line 30 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1868, WebApp.Url(item), 1868, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                                ");
#nullable restore
#line 31 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
                           Write(item.MenuTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </a>\r\n                            <div class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\">\r\n");
#nullable restore
#line 34 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
                                  
                                    var page = WebApp.Api.Archives.GetByIdAsync(item.Id).Result;
                                    foreach (var child in page.Posts)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 2470, "\"", 2493, 1);
#nullable restore
#line 38 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2477, child.Permalink, 2477, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 38 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
                                                                                    Write(child.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 39 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 44 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                \r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>      \r\n\r\n    ");
#nullable restore
#line 51 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n    <hr />\r\n    <footer>\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 56 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
             foreach(var item in WebApp.Site.Sitemap.Where(m => !m.IsHidden && m.PageTypeName != "Category Page"))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("href", " href=\"", 3009, "\"", 3031, 1);
#nullable restore
#line 58 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3016, item.Permalink, 3016, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 58 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
                                     Write(item.NavigationTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 59 "D:\cheapgit\cheapgit.web\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>
    </footer>
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e592fee62ba5cbfebbf46dbad2563a1c797f7b9318315", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
