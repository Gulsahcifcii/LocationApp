#pragma checksum "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\MainUnit\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efc744fd93526b7f452060085ab57fdffd65a49e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainUnit_List), @"mvc.1.0.view", @"/Views/MainUnit/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MainUnit/List.cshtml", typeof(AspNetCore.Views_MainUnit_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efc744fd93526b7f452060085ab57fdffd65a49e", @"/Views/MainUnit/List.cshtml")]
    public class Views_MainUnit_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/MainUnit/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\MainUnit\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(105, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(112, 60, false);
#line 7 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\MainUnit\List.cshtml"
Write(Html.Partial("/Views/Shared/Partials/DataTable/_Css.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(172, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(177, 433, true);
            WriteLiteral(@"<!-- page content -->
<div class=""right_col"" role=""main"">
    <div class="""">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Ana Birim</h3>
            </div>
            <div class=""title_right pull-right"">
                <div class=""col-md-12 col-sm-12 col-xs-12 col-lg-12 form-group pull-right"">
                    <div class=""input-group pull-right"">
                        ");
            EndContext();
            BeginContext(610, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26189516dd5d4e8eb412c5a5e278fea8", async() => {
                BeginContext(674, 38, true);
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i> Yeni");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(716, 1802, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Birimler<small></small></h2>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""x_content"">
                        <p class=""text-muted font-13 m-b-30"">
                        </p>
                        <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive nowrap"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>Ana Birimler</th>
                                    <th>İşlemler</th>
                                </tr>
                            </thead>
                            <tbody");
            WriteLiteral(@">
                                <tr>
                                    <td>-</td>
                                    <td>
                                        <button type=""button"" class=""btn btn-round btn-danger""><i class=""fa fa-edit fa-hover""></i><span class=""text-muted""></span></button>
                                        <button type=""button"" class=""btn btn-round btn-info""><i class=""fa fa-trash fa-hover""></i><span class=""text-muted""></span></button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- /page content -->
<!-- Modal -->
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2535, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2542, 59, false);
#line 61 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\MainUnit\List.cshtml"
Write(Html.Partial("/Views/Shared/Partials/DataTable/_Js.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(2601, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
