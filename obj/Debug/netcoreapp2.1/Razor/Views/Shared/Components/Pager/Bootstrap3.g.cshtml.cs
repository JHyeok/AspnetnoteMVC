#pragma checksum "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae69a44c5d87bb89d4e29430200f225f2bb3bf7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Bootstrap3), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Bootstrap3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Pager/Bootstrap3.cshtml", typeof(AspNetCore.Views_Shared_Components_Pager_Bootstrap3))]
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
#line 1 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\_ViewImports.cshtml"
using AspnetNote.MVC6;

#line default
#line hidden
#line 2 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\_ViewImports.cshtml"
using AspnetNote.MVC6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae69a44c5d87bb89d4e29430200f225f2bb3bf7b", @"/Views/Shared/Components/Pager/Bootstrap3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6812ab87d38bf5ca57f0d726addfa92bde9eeb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Bootstrap3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.IPagingList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(74, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
  
    var start = this.Model.StartPageIndex;
    var stop = this.Model.StopPageIndex;

#line default
#line hidden
            BeginContext(164, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
 if (this.Model.PageCount > 1) {

#line default
#line hidden
            BeginContext(198, 29, true);
            WriteLiteral("    <ul class=\"pagination\">\n\n");
            EndContext();
#line 13 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
         if (start > 1) {

#line default
#line hidden
            BeginContext(253, 35, true);
            WriteLiteral("            <li>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 288, "\"", 351, 1);
#line 15 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
WriteAttributeValue("", 295, Url.Action(Model.Action, Model.GetRouteValueForPage(1)), 295, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(352, 114, true);
            WriteLiteral(" aria-label=\"First\">\n                    <span aria-hidden=\"true\">1</span>\n                </a>\n            </li>\n");
            EndContext();
#line 19 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
        }

#line default
#line hidden
            BeginContext(476, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
         if (this.Model.PageIndex > 1) {

#line default
#line hidden
            BeginContext(518, 35, true);
            WriteLiteral("            <li>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 553, "\"", 639, 1);
#line 23 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
WriteAttributeValue("", 560, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex - 1)), 560, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(640, 123, true);
            WriteLiteral(" aria-label=\"Previous\">\n                    <span aria-hidden=\"true\">&laquo;</span>\n                </a>\n            </li>\n");
            EndContext();
#line 27 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
        }

#line default
#line hidden
            BeginContext(773, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 29 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
         for (int i = start; i <= stop; i++) {

#line default
#line hidden
            BeginContext(821, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 836, "\"", 887, 1);
#line 30 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
WriteAttributeValue("", 844, (Model.PageIndex == i) ? "active" : null, 844, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(888, 18, true);
            WriteLiteral(">\n                ");
            EndContext();
            BeginContext(907, 74, false);
#line 31 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
           Write(Html.ActionLink(i.ToString(), Model.Action, Model.GetRouteValueForPage(i)));

#line default
#line hidden
            EndContext();
            BeginContext(981, 19, true);
            WriteLiteral("\n            </li>\n");
            EndContext();
#line 33 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
        }

#line default
#line hidden
            BeginContext(1010, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 35 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
         if (this.Model.PageIndex < this.Model.PageCount) {

#line default
#line hidden
            BeginContext(1071, 35, true);
            WriteLiteral("            <li>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1106, "\"", 1192, 1);
#line 37 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
WriteAttributeValue("", 1113, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex + 1)), 1113, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1193, 119, true);
            WriteLiteral(" aria-label=\"Next\">\n                    <span aria-hidden=\"true\">&raquo;</span>\n                </a>\n            </li>\n");
            EndContext();
#line 41 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
        }

#line default
#line hidden
            BeginContext(1322, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 43 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
         if (stop < this.Model.PageCount) {

#line default
#line hidden
            BeginContext(1367, 35, true);
            WriteLiteral("            <li>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1402, "\"", 1484, 1);
#line 45 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
WriteAttributeValue("", 1409, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageCount)), 1409, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1485, 65, true);
            WriteLiteral(" aria-label=\"Last\">\n                    <span aria-hidden=\"true\">");
            EndContext();
            BeginContext(1551, 20, false);
#line 46 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
                                        Write(this.Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 47, true);
            WriteLiteral("</span>\n                </a>\n            </li>\n");
            EndContext();
#line 49 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
        }

#line default
#line hidden
            BeginContext(1628, 11, true);
            WriteLiteral("\n    </ul>\n");
            EndContext();
#line 52 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Shared\Components\Pager\Bootstrap3.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.IPagingList> Html { get; private set; }
    }
}
#pragma warning restore 1591
