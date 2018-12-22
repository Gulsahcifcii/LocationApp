#pragma checksum "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Campus\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49cdb3eb5f4ff4c1cc060c9348b3d0692bbd9e2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campus_List), @"mvc.1.0.view", @"/Views/Campus/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Campus/List.cshtml", typeof(AspNetCore.Views_Campus_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49cdb3eb5f4ff4c1cc060c9348b3d0692bbd9e2a", @"/Views/Campus/List.cshtml")]
    public class Views_Campus_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Campus\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(105, 553, true);
                WriteLiteral(@"
    <!-- Datatables -->
    <link href=""../vendors/datatables.net-bs/css/dataTables.bootstrap.min.css"" rel=""stylesheet"">
    <link href=""../vendors/datatables.net-buttons-bs/css/buttons.bootstrap.min.css"" rel=""stylesheet"">
    <link href=""../vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css"" rel=""stylesheet"">
    <link href=""../vendors/datatables.net-responsive-bs/css/responsive.bootstrap.min.css"" rel=""stylesheet"">
    <link href=""../vendors/datatables.net-scroller-bs/css/scroller.bootstrap.min.css"" rel=""stylesheet"">
");
                EndContext();
            }
            );
            BeginContext(661, 5286, true);
            WriteLiteral(@"<!-- page content -->
<div class=""right_col"" role=""main"">
    <div class="""">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Lokasyon <small> Kampüs</small></h3>
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
                        <h2>Kampüs<small></small></h2>
                        <div class=""clearfix""></div>
            ");
            WriteLiteral(@"        </div>
                    <div class=""x_content"">
                        <p class=""text-muted font-13 m-b-30"">
                        </p>
                        <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive nowrap"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>Kampüs Başlık</th>
                                    <th>Açıklama</th>
                                    <th>Diğer</th>
                                    <th>İşlemler</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>-</td>
                                    <td>-</td>
                                    <td>-</td>
                                    <td>
                                        <button type=""button"" class=""btn btn-round ");
            WriteLiteral(@"btn-danger""><i class=""fa fa-edit fa-hover""></i><span class=""text-muted""></span></button>
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
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Yeni Kampüs</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hi");
            WriteLiteral(@"dden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <form id=""demo-form2"" data-parsley-validate class=""form-horizontal form-label-left"">
                    <input type=""hidden"" id=""campusID"" />
                    <div class=""form-group"">
                        <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""name"">
                            Kampüs Başlık : <span class=""required"">*</span>
                        </label>
                        <div class=""col-md-6 col-sm-6 col-xs-12"">
                            <input type=""text"" id=""name"" name=""name"" required=""required"" class=""form-control col-md-7 col-xs-12"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""description"">
                            Açıklama <span class=""required"">*</span>
                        ");
            WriteLiteral(@"</label>
                        <div class=""col-md-6 col-sm-6 col-xs-12"">
                            <input type=""text"" id=""description"" name=""description"" required=""required"" class=""form-control col-md-7 col-xs-12"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""description"">
                            Diğer <span class=""required"">*</span>
                        </label>
                        <div class=""col-md-6 col-sm-6 col-xs-12"">
                            <input type=""text"" id=""other"" name=""other"" required=""required"" class=""form-control col-md-7 col-xs-12"">
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-primary"" type=""reset"">Temizle</button>
                <button type=""submit"" class=""btn btn-success"">Kaydet</");
            WriteLiteral("button>\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Kapat</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5964, 1328, true);
                WriteLiteral(@"
    <!-- Datatables -->
    <script src=""../vendors/datatables.net/js/jquery.dataTables.min.js""></script>
    <script src=""../vendors/datatables.net-bs/js/dataTables.bootstrap.min.js""></script>
    <script src=""../vendors/datatables.net-buttons/js/dataTables.buttons.min.js""></script>
    <script src=""../vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js""></script>
    <script src=""../vendors/datatables.net-buttons/js/buttons.flash.min.js""></script>
    <script src=""../vendors/datatables.net-buttons/js/buttons.html5.min.js""></script>
    <script src=""../vendors/datatables.net-buttons/js/buttons.print.min.js""></script>
    <script src=""../vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js""></script>
    <script src=""../vendors/datatables.net-keytable/js/dataTables.keyTable.min.js""></script>
    <script src=""../vendors/datatables.net-responsive/js/dataTables.responsive.min.js""></script>
    <script src=""../vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js""><");
                WriteLiteral(@"/script>
    <script src=""../vendors/datatables.net-scroller/js/dataTables.scroller.min.js""></script>
    <script src=""../vendors/jszip/dist/jszip.min.js""></script>
    <script src=""../vendors/pdfmake/build/pdfmake.min.js""></script>
    <script src=""../vendors/pdfmake/build/vfs_fonts.js""></script>
");
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
