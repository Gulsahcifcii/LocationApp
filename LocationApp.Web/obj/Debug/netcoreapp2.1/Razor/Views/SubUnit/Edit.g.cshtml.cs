#pragma checksum "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\SubUnit\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6be56c76b723a620dde835d0875bda0fc815e77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubUnit_Edit), @"mvc.1.0.view", @"/Views/SubUnit/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SubUnit/Edit.cshtml", typeof(AspNetCore.Views_SubUnit_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6be56c76b723a620dde835d0875bda0fc815e77", @"/Views/SubUnit/Edit.cshtml")]
    public class Views_SubUnit_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocationApp.Data.Database.subunit>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\SubUnit\Edit.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(147, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(154, 60, false);
#line 8 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\SubUnit\Edit.cshtml"
Write(Html.Partial("/Views/Shared/Partials/DataTable/_Css.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(214, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(219, 1022, true);
            WriteLiteral(@"<!-- page content -->
<div class=""right_col"" role=""main"">
    <div class="""">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Alt Birim </h3>
            </div>
            <div class=""title_right pull-right"">
                <div class=""col-md-12 col-sm-12 col-xs-12 col-lg-12 form-group pull-right"">
                    <div class=""input-group pull-right"">
                        <button type=""button"" data-toggle=""modal"" data-target=""#exampleModal"" class=""btn btn-success pull-right ""><i class=""fa fa-plus-circle""></i> Yeni</button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Alt Birim<small></small></h2>
                        <div class=""clearfix""></div>
                    </div>
");
            EndContext();
#line 33 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\SubUnit\Edit.cshtml"
                     using (Html.BeginForm("Edit", "SubUnit", FormMethod.Post, new { @class = "form-horizontal form-label-left" }))
                    {
                        

#line default
#line hidden
            BeginContext(1422, 40, false);
#line 35 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\SubUnit\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.SubUnitID));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 1171, true);
            WriteLiteral(@"                        <div class=""form-group"">
                            <div class=""form-group"">
                                <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""siteID"">Ana Birim:*</label>
                                <div class=""col-md-6 col-sm-6 col-xs-12"">
                                    <select id=""MainUnit"" class=""form-control"">
                                        <option>Choose option</option>
                                        <option>Option one</option>
                                        <option>Option two</option>
                                        <option>Option three</option>
                                        <option>Option four</option>
                                    </select>
                                </div>
                            </div>
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""name"">
                                Alt Birim:<span class=""required"">*</s");
            WriteLiteral("pan>\r\n                            </label>\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                ");
            EndContext();
            BeginContext(2636, 88, false);
#line 53 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\SubUnit\Edit.cshtml"
                           Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control col-md-7 col-xs-12" }));

#line default
#line hidden
            EndContext();
            BeginContext(2724, 70, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(2796, 396, true);
            WriteLiteral(@"                        <div class=""form-group"">
                            <div class=""col-md-6 col-sm-6 col-xs-12 col-md-offset-3"">
                                <button class=""btn btn-primary"" type=""button"">Listele</button>
                                <button type=""submit"" class=""btn btn-success"">Kaydet</button>
                            </div>
                        </div>
");
            EndContext();
#line 63 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\SubUnit\Edit.cshtml"
                    }

#line default
#line hidden
            BeginContext(3215, 106, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /page content -->\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3338, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3345, 59, false);
#line 72 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\SubUnit\Edit.cshtml"
Write(Html.Partial("/Views/Shared/Partials/DataTable/_Js.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(3404, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocationApp.Data.Database.subunit> Html { get; private set; }
    }
}
#pragma warning restore 1591
