#pragma checksum "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a78c3a9be053f8b206b189da159524e88638847e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Edit), @"mvc.1.0.view", @"/Views/Room/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/Edit.cshtml", typeof(AspNetCore.Views_Room_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a78c3a9be053f8b206b189da159524e88638847e", @"/Views/Room/Edit.cshtml")]
    public class Views_Room_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocationApp.Data.Database.room>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(144, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(151, 60, false);
#line 8 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml"
Write(Html.Partial("/Views/Shared/Partials/DataTable/_Css.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(211, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(216, 582, true);
            WriteLiteral(@"<!-- page content -->
<div class=""right_col"" role=""main"">
    <div class="""">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Lokasyon <small> Oda</small></h3>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Oda<small></small></h2>
                        <div class=""clearfix""></div>
                    </div>
");
            EndContext();
#line 26 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml"
                     using (Html.BeginForm("Edit", "Room", FormMethod.Post, new { @class = "form-horizontal form-label-left" }))
                    {
                        

#line default
#line hidden
            BeginContext(976, 37, false);
#line 28 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 2628, true);
            WriteLiteral(@"                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""siteID"">Kat :</label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                <select id=""FloorID"" class=""form-control"">
                                    <option>Choose option</option>
                                    <option>Option one</option>
                                    <option>Option two</option>
                                    <option>Option three</option>
                                    <option>Option four</option>
                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""siteID"">Oda Türü :</label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                <");
            WriteLiteral(@"select id=""FloorID"" class=""form-control"">
                                    <option>Choose option</option>
                                    <option>Option one</option>
                                    <option>Option two</option>
                                    <option>Option three</option>
                                    <option>Option four</option>
                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""siteID"">Kat :</label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                <select id=""FloorID"" class=""form-control"">
                                    <option>Choose option</option>
                                    <option>Option one</option>
                                    <option>Option two</option>
                               ");
            WriteLiteral(@"     <option>Option three</option>
                                    <option>Option four</option>
                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""name"">
                                Oda Başlık : <span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
            EndContext();
            BeginContext(3644, 88, false);
#line 70 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml"
                           Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control col-md-7 col-xs-12" }));

#line default
#line hidden
            EndContext();
            BeginContext(3732, 437, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""description"">
                                Map ? <span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
            EndContext();
            BeginContext(4170, 87, false);
#line 78 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml"
                           Write(Html.TextBoxFor(model => model.Map, new { @class = "form-control col-md-7 col-xs-12" }));

#line default
#line hidden
            EndContext();
            BeginContext(4257, 466, true);
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
#line 87 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml"
                    }

#line default
#line hidden
            BeginContext(4746, 106, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /page content -->\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4869, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4876, 59, false);
#line 96 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Room\Edit.cshtml"
Write(Html.Partial("/Views/Shared/Partials/DataTable/_Js.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(4935, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocationApp.Data.Database.room> Html { get; private set; }
    }
}
#pragma warning restore 1591
