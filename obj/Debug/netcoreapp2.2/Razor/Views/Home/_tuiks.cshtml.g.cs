#pragma checksum "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e7beb20aed21d3c559fe3883b5b535a14ff71b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__tuiks), @"mvc.1.0.view", @"/Views/Home/_tuiks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_tuiks.cshtml", typeof(AspNetCore.Views_Home__tuiks))]
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
#line 1 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\_ViewImports.cshtml"
using TuikSwe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e7beb20aed21d3c559fe3883b5b535a14ff71b", @"/Views/Home/_tuiks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807e7a5a732a474163e881b1b269a95d584e48b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__tuiks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tuik>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
 foreach (var tuik in Model)
{

#line default
#line hidden
            BeginContext(61, 118, true);
            WriteLiteral("    <div class=\"card mb-3\">\r\n        <div class=\"row no-gutter\">\r\n            <div class=\"col-md-3\">\r\n                ");
            EndContext();
            BeginContext(179, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71e7beb20aed21d3c559fe3883b5b535a14ff71b4523", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 189, "~/img/", 189, 6, true);
#line 8 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
AddHtmlAttributeValue("", 195, tuik.ImageUrl, 195, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
AddHtmlAttributeValue("", 216, tuik.Description, 216, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(252, 168, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">\r\n                        ");
            EndContext();
            BeginContext(420, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e7beb20aed21d3c559fe3883b5b535a14ff71b6776", async() => {
                BeginContext(491, 9, false);
#line 13 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
                                                                                         Write(tuik.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
                                                                        WriteLiteral(tuik.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(504, 28, true);
            WriteLiteral("\r\n                    </h5> ");
            EndContext();
            BeginContext(552, 41, true);
            WriteLiteral("\r\n                <p class=\"card-text\">\r\n");
            EndContext();
#line 16 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
                     if (tuik.ShortDescription == "")
                    {

#line default
#line hidden
            BeginContext(671, 135, true);
            WriteLiteral("                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                        No Data Found!\r\n                    </div>\r\n");
            EndContext();
#line 21 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(903, 21, false);
#line 24 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
                   Write(tuik.ShortDescription);

#line default
#line hidden
            EndContext();
#line 24 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
                                              
                    }

#line default
#line hidden
            BeginContext(949, 235, true);
            WriteLiteral("\r\n                </p>\r\n                    <p class=\"card-text\">\r\n                        <small class=\"text-muted\">3 days ago</small>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 35 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\_tuiks.cshtml"
}

#line default
#line hidden
            BeginContext(1187, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tuik>> Html { get; private set; }
    }
}
#pragma warning restore 1591