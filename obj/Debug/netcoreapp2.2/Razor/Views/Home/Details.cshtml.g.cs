#pragma checksum "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54fc997f26011610ee67a63666d980b1b8f6f15c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54fc997f26011610ee67a63666d980b1b8f6f15c", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807e7a5a732a474163e881b1b269a95d584e48b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuik>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 51, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n");
            EndContext();
            BeginContext(102, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(111, 43, false);
#line 7 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
   Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(154, 283, true);
            WriteLiteral(@"
    </div>
    <div class=""col-md-9"">
        <div class=""card mb-3"">
            <div class=""card-body"">
                <div class=""row no-gutter"">

                    <div class=""container"">

                        <h5 class=""card-title"">
                            ");
            EndContext();
            BeginContext(437, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fc997f26011610ee67a63666d980b1b8f6f15c4945", async() => {
                BeginContext(508, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(511, 10, false);
#line 17 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                                                                                                Write(Model.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                                                                            WriteLiteral(Model.Id);

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
            BeginContext(525, 358, true);
            WriteLiteral(@"
                        </h5>
                       
                        <p class=""card-text"">
                            <table id=""example"" class=""display"" style=""width:100%"">
                                <thead>
                                    <tr>
                                       
                                            ");
            EndContext();
            BeginContext(884, 31, false);
#line 25 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                                       Write(Html.Raw(Model.TableColumnName));

#line default
#line hidden
            EndContext();
            BeginContext(915, 135, true);
            WriteLiteral("\r\n   \r\n\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                                         if ( Model.Description == "")
                                        {

#line default
#line hidden
            BeginContext(1165, 207, true);
            WriteLiteral("                                            <div class=\"alert alert-danger\" role=\"alert\">\r\n                                                No Data Found!\r\n                                            </div>\r\n");
            EndContext();
#line 36 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1415, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1456, 27, false);
#line 37 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                                   Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 755, true);
            WriteLiteral(@"
                                   
               

                                </tbody>
                        </p>
                        <p class=""card-text"">
                            <small class=""text-muted"">3 days ago</small>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>



<script>

    $(document).ready(function () {
        $('#example').DataTable({
            dom: 'Bfrtip',
            buttons: [
                'copyHtml5',
                'excelHtml5',
                'csvHtml5',
                'pdfHtml5'
            ]
        });
    });
</script>



<!-- <div class=""row"">
    <div class=""col-md-3"">
");
            EndContext();
            BeginContext(2276, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2285, 43, false);
#line 75 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
   Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(2328, 225, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"card mb-3\">\r\n            <div class=\"card-body\">\r\n                <div class=\"row no-gutter\">\r\n                    <div class=\"col-md-4\">\r\n                        ");
            EndContext();
            BeginContext(2553, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "54fc997f26011610ee67a63666d980b1b8f6f15c11391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2563, "~/img/", 2563, 6, true);
#line 82 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 2569, Model.ImageUrl, 2569, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 82 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 2591, Model.Description, 2591, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2628, 153, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n\r\n                        <h5 class=\"card-title\">\r\n                            ");
            EndContext();
            BeginContext(2781, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fc997f26011610ee67a63666d980b1b8f6f15c13642", async() => {
                BeginContext(2852, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(2855, 10, false);
#line 87 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                                                                                                Write(Model.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                                                                            WriteLiteral(Model.Id);

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
            BeginContext(2869, 108, true);
            WriteLiteral("\r\n                        </h5>\r\n                        <p class=\"card-text\">\r\n                            ");
            EndContext();
            BeginContext(2978, 27, false);
#line 90 "C:\Users\Erdo\Visual Studio 2019\Projects\TuikSwe\Views\Home\Details.cshtml"
                       Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3005, 351, true);
            WriteLiteral(@"
                        </p>
                        <p class=""card-text"">
                            <small class=""text-muted"">3 days ago</small>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div> -- >


    <div class=""row"">
    <div class=""col-md-3"">
");
            EndContext();
            BeginContext(3449, 253, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"card mb-3\">\r\n            <div class=\"card-body\">\r\n                <div class=\"row no-gutter\">\r\n\r\n                    <div class=\"container\">\r\n\r\n                        <h5 class=\"card-title\">\r\n");
            EndContext();
            BeginContext(3960, 1496, true);
            WriteLiteral(@"                        </p>
                        <p class=""card-text"">
                            <table id=""example"" class=""display"" style=""width:100%"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Position</th>
                                        <th>Office</th>
                                        <th>Age</th>
                                        <th>Start date</th>
                                        <th>Salary</th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tiger Nixon</td>
                                        <td>System Architect</td>
                                        <td>Edinburgh</td>
                                        <td>61</td>
                        ");
            WriteLiteral(@"                <td>2011/04/25</td>
                                        <td>$320,800</td>
                                    </tr>

                                </tbody>
                        </p>
                        <p class=""card-text"">
                            <small class=""text-muted"">3 days ago</small>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuik> Html { get; private set; }
    }
}
#pragma warning restore 1591