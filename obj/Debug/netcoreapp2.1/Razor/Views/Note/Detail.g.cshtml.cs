#pragma checksum "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0d58f3a28d8b08271205c6c75e43b0aa57e9c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Detail), @"mvc.1.0.view", @"/Views/Note/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Note/Detail.cshtml", typeof(AspNetCore.Views_Note_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0d58f3a28d8b08271205c6c75e43b0aa57e9c2", @"/Views/Note/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6812ab87d38bf5ca57f0d726addfa92bde9eeb", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Note", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 90, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h3 class=\"page-header\">상세 읽기 - ");
            EndContext();
            BeginContext(91, 15, false);
#line 4 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Detail.cshtml"
                                   Write(Model.NoteTitle);

#line default
#line hidden
            EndContext();
            BeginContext(106, 208, true);
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-10\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-heading text-left\">\r\n                <label>제목 : </label> ");
            EndContext();
            BeginContext(315, 15, false);
#line 12 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Detail.cshtml"
                                Write(Model.NoteTitle);

#line default
#line hidden
            EndContext();
            BeginContext(330, 46, true);
            WriteLiteral(" <br/>\r\n                <label>작성자 : </label> ");
            EndContext();
            BeginContext(377, 19, false);
#line 13 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Detail.cshtml"
                                 Write(Model.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(396, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                ");
            EndContext();
            BeginContext(473, 28, false);
#line 16 "C:\Users\JaeHyuk\source\repos\AspnetNote\AspnetNote.MVC6\Views\Note\Detail.cshtml"
           Write(Html.Raw(Model.NoteContents));

#line default
#line hidden
            EndContext();
            BeginContext(501, 89, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-footer text-right\">\r\n                ");
            EndContext();
            BeginContext(590, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e60f19a33e4f8b8b5b3a41055cc7f9", async() => {
                BeginContext(658, 2, true);
                WriteLiteral("목록");
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
            BeginContext(664, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
