#pragma checksum "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71bb0f94434129fddb03895f06d440c4f0e9a85d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Index), @"mvc.1.0.view", @"/Views/Catalog/Index.cshtml")]
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
#line 1 "C:\sunrise\Sunrise2.0\Views\_ViewImports.cshtml"
using Sunrise2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\sunrise\Sunrise2.0\Views\_ViewImports.cshtml"
using Sunrise2._0.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
using Sunrise2._0.Storage.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bb0f94434129fddb03895f06d440c4f0e9a85d", @"/Views/Catalog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7a57cff10fa8647bf5bbb3ec2b981f9db562fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tour>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("catalog-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
  
    ViewData["Title"] = "????????";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""service"">
    <div class=""container"">
        <h3 class=""service__title"">??????????????</h3>
        <div class=""service__descr"">A responsive, retina-ready & wide multipurpose template.</div>
    </div>
</div>


<section class=""catalog"">
    <div class=""container"">
        <aside class=""catalog__aside"">
        </aside>

        <div class=""catalog__content"">
            <div class=""row"">



");
#nullable restore
#line 27 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
                 foreach (var t in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bb0f94434129fddb03895f06d440c4f0e9a85d4467", async() => {
                WriteLiteral("\r\n                            <div class=\"catalog-item__img\">\r\n                                <img src=\"img/slider/slide1.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 833, "\"", 839, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"catalog-item__content\">\r\n                                <div class=\"catalog-item__title\">");
#nullable restore
#line 35 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
                                                            Write(t.Hotel.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                <div class=\"catalog-item__city\">");
#nullable restore
#line 36 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
                                                           Write(t.Hotel.Town.Region.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 36 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
                                                                                      Write(t.Hotel.Town.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                <div class=\"catalog-item__price\">\r\n                                    ");
#nullable restore
#line 38 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
                               Write(t.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <span class=\"price__currency\">??????</span>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 664, "~/Catalog/Buy/", 664, 14, true);
#nullable restore
#line 30 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
AddHtmlAttributeValue("", 678, t.Id, 678, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 44 "C:\sunrise\Sunrise2.0\Views\Catalog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tour>> Html { get; private set; }
    }
}
#pragma warning restore 1591
