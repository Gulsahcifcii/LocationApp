#pragma checksum "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c28e3acba38d852ab458e03bd877f814a3517a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c28e3acba38d852ab458e03bd877f814a3517a7", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 1352, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81ae1c65d75b443bb825e498dd17442a", async() => {
                BeginContext(41, 362, true);
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""icon"" href=""images/favicon.ico"" type=""image/ico"" />
    <title>");
                EndContext();
                BeginContext(404, 13, false);
#line 10 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(417, 920, true);
                WriteLiteral(@" Gentelella Alela! | </title>
    <!-- Bootstrap -->
    <link href=""../vendors/bootstrap/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Font Awesome -->
    <link href=""../vendors/font-awesome/css/font-awesome.min.css"" rel=""stylesheet"">
    <!-- NProgress -->
    <link href=""../vendors/nprogress/nprogress.css"" rel=""stylesheet"">
    <!-- iCheck -->
    <link href=""../vendors/iCheck/skins/flat/green.css"" rel=""stylesheet"">

    <!-- bootstrap-progressbar -->
    <link href=""../vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css"" rel=""stylesheet"">
    <!-- JQVMap -->
    <link href=""../vendors/jqvmap/dist/jqvmap.min.css"" rel=""stylesheet"" />
    <!-- bootstrap-daterangepicker -->
    <link href=""../vendors/bootstrap-daterangepicker/daterangepicker.css"" rel=""stylesheet"">
    <!-- Custom Theme Style -->
    <link href=""../build/css/custom.min.css"" rel=""stylesheet"">
    ");
                EndContext();
                BeginContext(1338, 40, false);
#line 28 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("Styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1378, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1387, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1389, 12342, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad7aa141f41841afaf0675765ab3d9a3", async() => {
                BeginContext(1410, 9796, true);
                WriteLiteral(@"
    <div class=""container body"">
        <div class=""main_container"">
            <div class=""col-md-3 left_col"">
                <div class=""left_col scroll-view"">
                    <div class=""navbar nav_title"" style=""border: 0;"">
                        <a href=""index.html"" class=""site_title""><i class=""fa fa-paw""></i> <span>Gentelella Alela!</span></a>
                    </div>
                    <div class=""clearfix""></div>
                    <!-- menu profile quick info -->
                    <div class=""profile clearfix"">
                        <div class=""profile_pic"">
                            <img src=""images/img.jpg"" alt=""..."" class=""img-circle profile_img"">
                        </div>
                        <div class=""profile_info"">
                            <span>Welcome,</span>
                            <h2>John Doe</h2>
                        </div>
                    </div>
                    <!-- /menu profile quick info -->

                    <br /");
                WriteLiteral(@">
                    <!-- sidebar menu -->
                    <div id=""sidebar-menu"" class=""main_menu_side hidden-print main_menu"">
                        <div class=""menu_section"">
                            <h3>Lokasyon</h3>
                            <ul class=""nav side-menu"">
                                <li>
                                    <a><i class=""fa fa-home""></i> Tanımlar <span class=""fa fa-chevron-down""></span></a>
                                    <ul class=""nav child_menu"">
                                        <li><a href=""/Block/List"">Blok</a></li>
                                        <li><a href=""/Build/List"">Bina</a></li>
                                        <li><a href=""/Campus/List"">Kampüs</a></li>
                                        <li><a href=""/Department/List"">Departman</a></li>
                                        <li><a href=""/Floor/List"">Katlar</a></li>
                                    </ul>
                                </li>
      ");
                WriteLiteral(@"                      </ul>
                            <h3>Personel</h3>
                            <ul class=""nav side-menu"">
                                <li>
                                    <a><i class=""fa fa-home""></i> Tanımlar <span class=""fa fa-chevron-down""></span></a>
                                    <ul class=""nav child_menu"">
                                        <li><a href=""#"">Tümü</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <!-- /sidebar menu -->
                    <!-- /menu footer buttons -->
                    <div class=""sidebar-footer hidden-small"">
                        <a data-toggle=""tooltip"" data-placement=""top"" title=""Settings"">
                            <span class=""glyphicon glyphicon-cog"" aria-hidden=""true""></span>
                        </a>
                        <a data-toggle=""tooltip"" ");
                WriteLiteral(@"data-placement=""top"" title=""FullScreen"">
                            <span class=""glyphicon glyphicon-fullscreen"" aria-hidden=""true""></span>
                        </a>
                        <a data-toggle=""tooltip"" data-placement=""top"" title=""Lock"">
                            <span class=""glyphicon glyphicon-eye-close"" aria-hidden=""true""></span>
                        </a>
                        <a data-toggle=""tooltip"" data-placement=""top"" title=""Logout"" href=""login.html"">
                            <span class=""glyphicon glyphicon-off"" aria-hidden=""true""></span>
                        </a>
                    </div>
                    <!-- /menu footer buttons -->
                </div>
            </div>
            <!-- top navigation -->
            <div class=""top_nav"">
                <div class=""nav_menu"">
                    <nav>
                        <div class=""nav toggle"">
                            <a id=""menu_toggle""><i class=""fa fa-bars""></i></a>
               ");
                WriteLiteral(@"         </div>

                        <ul class=""nav navbar-nav navbar-right"">
                            <li class="""">
                                <a href=""javascript:;"" class=""user-profile dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false"">
                                    <img src=""images/img.jpg"" alt="""">John Doe
                                    <span class="" fa fa-angle-down""></span>
                                </a>
                                <ul class=""dropdown-menu dropdown-usermenu pull-right"">
                                    <li><a href=""javascript:;""> Profile</a></li>
                                    <li>
                                        <a href=""javascript:;"">
                                            <span class=""badge bg-red pull-right"">50%</span>
                                            <span>Settings</span>
                                        </a>
                                    </li>
                                   ");
                WriteLiteral(@" <li><a href=""javascript:;"">Help</a></li>
                                    <li><a href=""login.html""><i class=""fa fa-sign-out pull-right""></i> Log Out</a></li>
                                </ul>
                            </li>

                            <li role=""presentation"" class=""dropdown"">
                                <a href=""javascript:;"" class=""dropdown-toggle info-number"" data-toggle=""dropdown"" aria-expanded=""false"">
                                    <i class=""fa fa-envelope-o""></i>
                                    <span class=""badge bg-green"">6</span>
                                </a>
                                <ul id=""menu1"" class=""dropdown-menu list-unstyled msg_list"" role=""menu"">
                                    <li>
                                        <a>
                                            <span class=""image""><img src=""images/img.jpg"" alt=""Profile Image"" /></span>
                                            <span>
                          ");
                WriteLiteral(@"                      <span>John Smith</span>
                                                <span class=""time"">3 mins ago</span>
                                            </span>
                                            <span class=""message"">
                                                Film festivals used to be do-or-die moments for movie makers. They were where...
                                            </span>
                                        </a>
                                    </li>
                                    <li>
                                        <a>
                                            <span class=""image""><img src=""images/img.jpg"" alt=""Profile Image"" /></span>
                                            <span>
                                                <span>John Smith</span>
                                                <span class=""time"">3 mins ago</span>
                                            </span>
                          ");
                WriteLiteral(@"                  <span class=""message"">
                                                Film festivals used to be do-or-die moments for movie makers. They were where...
                                            </span>
                                        </a>
                                    </li>
                                    <li>
                                        <a>
                                            <span class=""image""><img src=""images/img.jpg"" alt=""Profile Image"" /></span>
                                            <span>
                                                <span>John Smith</span>
                                                <span class=""time"">3 mins ago</span>
                                            </span>
                                            <span class=""message"">
                                                Film festivals used to be do-or-die moments for movie makers. They were where...
                                        ");
                WriteLiteral(@"    </span>
                                        </a>
                                    </li>
                                    <li>
                                        <a>
                                            <span class=""image""><img src=""images/img.jpg"" alt=""Profile Image"" /></span>
                                            <span>
                                                <span>John Smith</span>
                                                <span class=""time"">3 mins ago</span>
                                            </span>
                                            <span class=""message"">
                                                Film festivals used to be do-or-die moments for movie makers. They were where...
                                            </span>
                                        </a>
                                    </li>
                                    <li>
                                        <div class=""text-center"">
 ");
                WriteLiteral(@"                                           <a>
                                                <strong>See All Alerts</strong>
                                                <i class=""fa fa-angle-right""></i>
                                            </a>
                                        </div>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
            <!-- /top navigation -->
            ");
                EndContext();
                BeginContext(11207, 12, false);
#line 194 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(11219, 2461, true);
                WriteLiteral(@"
            <!-- /page content -->
            <!-- footer content -->
            <footer>
                <div class=""pull-right"">
                    Gentelella - Bootstrap Admin Template by <a href=""https://colorlib.com"">Colorlib</a>
                </div>
                <div class=""clearfix""></div>
            </footer>
            <!-- /footer content -->
        </div>
    </div>
    <!-- jQuery -->
    <script src=""../vendors/jquery/dist/jquery.min.js""></script>
    <!-- Bootstrap -->
    <script src=""../vendors/bootstrap/dist/js/bootstrap.min.js""></script>
    <!-- FastClick -->
    <script src=""../vendors/fastclick/lib/fastclick.js""></script>
    <!-- NProgress -->
    <script src=""../vendors/nprogress/nprogress.js""></script>
    <!-- Chart.js -->
    <script src=""../vendors/Chart.js/dist/Chart.min.js""></script>
    <!-- gauge.js -->
    <script src=""../vendors/gauge.js/dist/gauge.min.js""></script>
    <!-- bootstrap-progressbar -->
    <script src=""../vendors/bootstrap-pr");
                WriteLiteral(@"ogressbar/bootstrap-progressbar.min.js""></script>
    <!-- iCheck -->
    <script src=""../vendors/iCheck/icheck.min.js""></script>
    <!-- Skycons -->
    <script src=""../vendors/skycons/skycons.js""></script>
    <!-- Flot -->
    <script src=""../vendors/Flot/jquery.flot.js""></script>
    <script src=""../vendors/Flot/jquery.flot.pie.js""></script>
    <script src=""../vendors/Flot/jquery.flot.time.js""></script>
    <script src=""../vendors/Flot/jquery.flot.stack.js""></script>
    <script src=""../vendors/Flot/jquery.flot.resize.js""></script>
    <!-- Flot plugins -->
    <script src=""../vendors/flot.orderbars/js/jquery.flot.orderBars.js""></script>
    <script src=""../vendors/flot-spline/js/jquery.flot.spline.min.js""></script>
    <script src=""../vendors/flot.curvedlines/curvedLines.js""></script>
    <!-- DateJS -->
    <script src=""../vendors/DateJS/build/date.js""></script>
    <!-- JQVMap -->
    <script src=""../vendors/jqvmap/dist/jquery.vmap.js""></script>
    <script src=""../vendors/jqvmap/d");
                WriteLiteral(@"ist/maps/jquery.vmap.world.js""></script>
    <script src=""../vendors/jqvmap/examples/js/jquery.vmap.sampledata.js""></script>
    <!-- bootstrap-daterangepicker -->
    <script src=""../vendors/moment/min/moment.min.js""></script>
    <script src=""../vendors/bootstrap-daterangepicker/daterangepicker.js""></script>

    <!-- Custom Theme Scripts -->
    <script src=""../build/js/custom.min.js""></script>
    ");
                EndContext();
                BeginContext(13681, 41, false);
#line 246 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(13722, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13731, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
