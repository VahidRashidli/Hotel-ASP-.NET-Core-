#pragma checksum "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d7491de6e30746b66fafc49a67ecbd30448eb1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.ViewModels.AdminViewModels.UserViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.ViewModels.AdminViewModels.AdminHotelViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.ViewModels.AdminViewModels.AdminRoomViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.ViewModels.AboutPageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.Models.WebsiteSections.AboutPageSections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.ViewModels.AdminViewModels.AdminReservationViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.ViewModels.AdminViewModels.AboutPageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.Constants.POCOConstants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.Utilities.ControllerUtilities.UserUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel.Utilities.ControllerUtilities.AdminHotelUtilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d7491de6e30746b66fafc49a67ecbd30448eb1c", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a91449a1a4970f26759f40679975a8e28aa6f9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/dist/img/user1-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-size-50 mr-3 img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/dist/img/user8-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-size-50 img-circle mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/dist/img/user3-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Navbar -->\r\n");
            DefineSection("Navbar", async() => {
                WriteLiteral(@"
    <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
        <!-- Left navbar links -->
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
            </li>
            <li class=""nav-item d-none d-sm-inline-block"">
                <a href=""index3.html"" class=""nav-link"">Home</a>
            </li>
            <li class=""nav-item d-none d-sm-inline-block"">
                <a href=""#"" class=""nav-link"">Contact</a>
            </li>
        </ul>

        <!-- Right navbar links -->
        <ul class=""navbar-nav ml-auto"">
            <!-- Navbar Search -->
            <li class=""nav-item"">
                <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                    <i class=""fas fa-search""></i>
                </a>
                <div class=""navbar-search-block"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d7491de6e30746b66fafc49a67ecbd30448eb1c9617", async() => {
                    WriteLiteral(@"
                        <div class=""input-group input-group-sm"">
                            <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-navbar"" type=""submit"">
                                    <i class=""fas fa-search""></i>
                                </button>
                                <button class=""btn btn-navbar"" type=""button"" data-widget=""navbar-search"">
                                    <i class=""fas fa-times""></i>
                                </button>
                            </div>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </li>

            <!-- Messages Dropdown Menu -->
            <li class=""nav-item dropdown"">
                <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                    <i class=""far fa-comments""></i>
                    <span class=""badge badge-danger navbar-badge"">3</span>
                </a>
                <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                    <a href=""#"" class=""dropdown-item"">
                        <!-- Message Start -->
                        <div class=""media"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d7491de6e30746b66fafc49a67ecbd30448eb1c12411", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <div class=""media-body"">
                                <h3 class=""dropdown-item-title"">
                                    Brad Diesel
                                    <span class=""float-right text-sm text-danger""><i class=""fas fa-star""></i></span>
                                </h3>
                                <p class=""text-sm"">Call me whenever you can...</p>
                                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                            </div>
                        </div>
                        <!-- Message End -->
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item"">
                        <!-- Message Start -->
                        <div class=""media"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d7491de6e30746b66fafc49a67ecbd30448eb1c14592", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <div class=""media-body"">
                                <h3 class=""dropdown-item-title"">
                                    John Pierce
                                    <span class=""float-right text-sm text-muted""><i class=""fas fa-star""></i></span>
                                </h3>
                                <p class=""text-sm"">I got your message bro</p>
                                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                            </div>
                        </div>
                        <!-- Message End -->
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item"">
                        <!-- Message Start -->
                        <div class=""media"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d7491de6e30746b66fafc49a67ecbd30448eb1c16767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <div class=""media-body"">
                                <h3 class=""dropdown-item-title"">
                                    Nora Silvester
                                    <span class=""float-right text-sm text-warning""><i class=""fas fa-star""></i></span>
                                </h3>
                                <p class=""text-sm"">The subject goes here</p>
                                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                            </div>
                        </div>
                        <!-- Message End -->
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item dropdown-footer"">See All Messages</a>
                </div>
            </li>
            <!-- Notifications Dropdown Menu -->
            <li class=""nav-item dropdown"">
                <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
    ");
                WriteLiteral(@"                <i class=""far fa-bell""></i>
                    <span class=""badge badge-warning navbar-badge"">15</span>
                </a>
                <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                    <span class=""dropdown-item dropdown-header"">15 Notifications</span>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item"">
                        <i class=""fas fa-envelope mr-2""></i> 4 new messages
                        <span class=""float-right text-muted text-sm"">3 mins</span>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item"">
                        <i class=""fas fa-users mr-2""></i> 8 friend requests
                        <span class=""float-right text-muted text-sm"">12 hours</span>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdow");
                WriteLiteral(@"n-item"">
                        <i class=""fas fa-file mr-2""></i> 3 new reports
                        <span class=""float-right text-muted text-sm"">2 days</span>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item dropdown-footer"">See All Notifications</a>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-widget=""fullscreen"" href=""#"" role=""button"">
                    <i class=""fas fa-expand-arrows-alt""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"" role=""button"">
                    <i class=""fas fa-th-large""></i>
                </a>
            </li>
        </ul>
    </nav>
");
            }
            );
            WriteLiteral(@"<!-- /.navbar -->
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Dashboard</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d7491de6e30746b66fafc49a67ecbd30448eb1c21733", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"">Dashboard</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <!-- Small boxes (Stat box) -->
            <div class=""row"">
                <div class=""col-12"">
                    <h1>Hello ");
#nullable restore
#line 165 "C:\Users\User\OneDrive\Рабочий стол\Hotel\Hotel\Areas\Admin\Views\Home\Index.cshtml"
                         Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n                </div>\r\n            </div>\r\n        </div><!-- /.container-fluid -->\r\n    </section>\r\n    <!-- /.content -->\r\n</div>\r\n<!-- /.content-wrapper -->");
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
