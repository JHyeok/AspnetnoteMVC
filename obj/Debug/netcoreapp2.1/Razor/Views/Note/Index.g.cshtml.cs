#pragma checksum "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37fab041d195ad2f8c7b8764a7f36bc759db7b37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Index), @"mvc.1.0.view", @"/Views/Note/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Note/Index.cshtml", typeof(AspNetCore.Views_Note_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37fab041d195ad2f8c7b8764a7f36bc759db7b37", @"/Views/Note/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6812ab87d38bf5ca57f0d726addfa92bde9eeb", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Note", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 183, true);
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>번호</th>\r\n            <th>제목</th>\r\n            <th>작성자</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 10 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Index.cshtml"
         foreach (var note in Model)
        {

#line default
#line hidden
            BeginContext(232, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(263, 11, false);
#line 13 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Index.cshtml"
           Write(note.NoteNo);

#line default
#line hidden
            EndContext();
            BeginContext(274, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(298, 14, false);
#line 14 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Index.cshtml"
           Write(note.NoteTitle);

#line default
#line hidden
            EndContext();
            BeginContext(312, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(336, 11, false);
#line 15 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Index.cshtml"
           Write(note.UserNo);

#line default
#line hidden
            EndContext();
            BeginContext(347, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 17 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(380, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(404, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09d1ff811f304273b130866abcfbde33", async() => {
                BeginContext(470, 6, true);
                WriteLiteral("게시물 작성");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
