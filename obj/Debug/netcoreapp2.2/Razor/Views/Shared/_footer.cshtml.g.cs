#pragma checksum "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Shared\_footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "643217b14cbe5f283b186a4428b4ea8d92b8238d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__footer), @"mvc.1.0.view", @"/Views/Shared/_footer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_footer.cshtml", typeof(AspNetCore.Views_Shared__footer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643217b14cbe5f283b186a4428b4ea8d92b8238d", @"/Views/Shared/_footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807e7a5a732a474163e881b1b269a95d584e48b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 146, true);
            WriteLiteral("<div class=\"footer py-3 mt-3 fixed-bottom\">\r\n    <div class=\"container text-center \">\r\n        <span class=\"text-muted\">\r\n            Copyright © ");
            EndContext();
            BeginContext(147, 17, false);
#line 4 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Shared\_footer.cshtml"
                   Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(164, 61, true);
            WriteLiteral(" All Rights Reserved\r\n        </span>\r\n\r\n    </div>\r\n\r\n</div>");
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