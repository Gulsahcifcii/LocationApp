#pragma checksum "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ab528f0bb0cfd8a4f2de2a4cbf7c740cfe8dc81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Block_Edit), @"mvc.1.0.view", @"/Views/Block/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Block/Edit.cshtml", typeof(AspNetCore.Views_Block_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab528f0bb0cfd8a4f2de2a4cbf7c740cfe8dc81", @"/Views/Block/Edit.cshtml")]
    public class Views_Block_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocationApp.Data.Database.block>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(145, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(152, 60, false);
#line 8 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml"
Write(Html.Partial("/Views/Shared/Partials/DataTable/_Css.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(212, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(217, 587, true);
            WriteLiteral(@"<!-- page content -->
<div class=""right_col"" role=""main"">
    <div class="""">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Lokasyon <small> Blok</small></h3>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Bloklar<small></small></h2>
                        <div class=""clearfix""></div>
                    </div>
");
            EndContext();
#line 26 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml"
                     using (Html.BeginForm("Edit", "Block", FormMethod.Post, new { @class = "form-horizontal form-label-left" }))
                    {
                        

#line default
#line hidden
            BeginContext(983, 38, false);
#line 28 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.BlockID));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 1215, true);
            WriteLiteral(@"                        <input type=""hidden"" id=""buildID"" style=""visibility:hidden"" />
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""siteID"">Bina Başlık :</label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                <select id=""siteID"" class=""form-control"">
                                    <option>Choose option</option>
                                    <option>Option one</option>
                                    <option>Option two</option>
                                    <option>Option three</option>
                                    <option>Option four</option>
                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""name"">
                             ");
            WriteLiteral("   Blok Başlık : <span class=\"required\">*</span>\r\n                            </label>\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                ");
            EndContext();
            BeginContext(2239, 88, false);
#line 47 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml"
                           Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control col-md-7 col-xs-12" }));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 429, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""gps"">
                                Gps : <span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
            EndContext();
            BeginContext(2757, 87, false);
#line 55 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml"
                           Write(Html.TextBoxFor(model => model.Gps, new { @class = "form-control col-md-7 col-xs-12" }));

#line default
#line hidden
            EndContext();
            BeginContext(2844, 466, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-md-6 col-sm-6 col-xs-12 col-md-offset-3"">
                                <button class=""btn btn-primary"" type=""button"">Listele</button>
                                <button type=""submit"" class=""btn btn-success"">Kaydet</button>
                            </div>
                        </div>
");
            EndContext();
#line 64 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml"
                    }

#line default
#line hidden
            BeginContext(3333, 106, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /page content -->\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3456, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3463, 59, false);
#line 73 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Block\Edit.cshtml"
Write(Html.Partial("/Views/Shared/Partials/DataTable/_Js.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(3522, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocationApp.Data.Database.block> Html { get; private set; }
    }
}
#pragma warning restore 1591
