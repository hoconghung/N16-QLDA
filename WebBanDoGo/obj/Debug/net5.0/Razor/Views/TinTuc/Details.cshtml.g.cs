#pragma checksum "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16292904e7618ee7227e4b321caeba63d2a3e36f1aad069200ef22096aca01f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TinTuc_Details), @"mvc.1.0.view", @"/Views/TinTuc/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\_ViewImports.cshtml"
using WebBanDoGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\_ViewImports.cshtml"
using WebBanDoGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"16292904e7618ee7227e4b321caeba63d2a3e36f1aad069200ef22096aca01f2", @"/Views/TinTuc/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b9c83727686732f5bcc18944bad4e014de00b9d54da5c831acab95708e36e58d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TinTuc_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanDoGo.Models.TinTuc>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/css_content.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_ProductLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16292904e7618ee7227e4b321caeba63d2a3e36f1aad069200ef22096aca01f25936", async() => {
                WriteLiteral("\r\n    <!-- Stylesheet -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "16292904e7618ee7227e4b321caeba63d2a3e36f1aad069200ef22096aca01f26249", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n    <div id=\"header\" class=\"location-page\" style=\"margin-bottom:20px;\">\r\n            <section class=\"c-breadcrumbs\">\r\n                <div class=\"container\">\r\n                    <span class=\"item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16292904e7618ee7227e4b321caeba63d2a3e36f1aad069200ef22096aca01f28372", async() => {
                WriteLiteral("Trang chủ ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                      <span class=\"item\"> > Tin Tức </span>\r\n                </div>\r\n              </section>\r\n        </div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16292904e7618ee7227e4b321caeba63d2a3e36f1aad069200ef22096aca01f29905", async() => {
                WriteLiteral(@"
    <!-- ##### Intro News Area Start ##### -->
    <section class=""intro-news-area section-padding-100-0 mb-70"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <!-- Intro News Tabs Area -->
                <div class=""col-12 col-lg-8"">
                    <div class=""intro-news-tab"">

                        <!-- Intro News Filter -->
                        <div class=""intro-news-filter d-flex justify-content-between"">
                            <h6>Chi Tiết Tin Tức</h6>
                            <nav>
                                <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                                    <a class=""nav-item nav-link active"" id=""nav1"" data-toggle=""tab"" href=""#nav-1"" role=""tab"" aria-controls=""nav-1"" aria-selected=""true"">Tin Mới</a>
                                    <a class=""nav-item nav-link"" id=""nav2"" data-toggle=""tab"" href=""#nav-2"" role=""tab"" aria-controls=""nav-2"" aria-selected=""false"">Giảm Giá</a>");
                WriteLiteral(@"
                                    <a class=""nav-item nav-link"" id=""nav3"" data-toggle=""tab"" href=""#nav-3"" role=""tab"" aria-controls=""nav-3"" aria-selected=""false"">Sản Phẩm Mới</a>
                                    <a class=""nav-item nav-link"" id=""nav4"" data-toggle=""tab"" href=""#nav-4"" role=""tab"" aria-controls=""nav-4"" aria-selected=""false"">Cửa Hàng</a>
                                </div>
                            </nav>
                        </div>

                        <div class=""tab-content"" id=""nav-tabContent"">
                            <div class=""tab-pane fade show active"" id=""nav-1"" role=""tabpanel"" aria-labelledby=""nav1"">
                                <div class=""row"">
");
#nullable restore
#line 46 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                     if (Model.LoaiTin == false)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <!-- Single News Area -->
                                    <div class=""col-12"">
                                        <div class=""single-blog-post style-2 mb-5"">
                                            <!-- Blog Thumbnail -->
                                            <div class=""blog-thumbnail"">
                                                <a");
                BeginWriteAttribute("href", " href=\"", 2874, "\"", 2881, 0);
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 2887, "\"", 2905, 1);
#nullable restore
#line 53 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
WriteAttributeValue("", 2893, Model.AnhTt, 2893, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2906, "\"", 2912, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                                            </div>

                                            <!-- Blog Content -->
                                            <div class=""blog-content"">
                                                <span class=""post-date"">");
#nullable restore
#line 58 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                   Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                <a href=\"#\" class=\"post-title\">");
#nullable restore
#line 59 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                          Write(Model.TenTt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                <a href=\"#\" class=\"post-author mb-30\">Người viết ");
#nullable restore
#line 60 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                                            Write(Model.Tacgia);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 3474, "\"", 3481, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"post-title\"><h4>");
#nullable restore
#line 61 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                             Write(Model.Motangan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4></a>\r\n                                                <p>");
#nullable restore
#line 62 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Motadai));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                        </div>\r\n");
#nullable restore
#line 66 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <!-- Single News Area -->
                                    <div class=""col-12"">
                                        <div class=""single-blog-post style-2 mb-5"">
                                            <!-- Blog Thumbnail -->
                                            <div class=""blog-thumbnail"">
                                                <video autoplay controls>
                                            <source");
                BeginWriteAttribute("src", " src=\"", 4376, "\"", 4394, 1);
#nullable restore
#line 75 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
WriteAttributeValue("", 4382, Model.AnhTt, 4382, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                </video>
                                            </div>

                                            <!-- Blog Content -->
                                            <div class=""blog-content"">
                                                <span class=""post-date"">");
#nullable restore
#line 81 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                   Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                <a href=\"#\" class=\"post-title\">");
#nullable restore
#line 82 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                          Write(Model.TenTt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                <a href=\"#\" class=\"post-author mb-30\">Người viết ");
#nullable restore
#line 83 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                                            Write(Model.Tacgia);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 5010, "\"", 5017, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"post-title\"><h4>");
#nullable restore
#line 84 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                             Write(Model.Motangan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4></a>\r\n                                                <p>");
#nullable restore
#line 85 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Motadai));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 89 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                </div>
                            </div>

                        </div>
                    </div>
                </div>

                <!-- Sidebar Widget -->
                <div class=""col-12 col-sm-9 col-md-6 col-lg-4"">
                    <div class=""sidebar-area"">
                     
                        <!-- Latest News Widget -->
                        <div class=""single-widget-area news-widget mb-30"">
                            <h4>Các Bài Viết Khác</h4>
");
#nullable restore
#line 106 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                              
                                WebBanDoGo.Models.NoiThatDatabaseContext db = new WebBanDoGo.Models.NoiThatDatabaseContext();
                                var tintuc = db.TinTucs.Where(p => p.LoaiTin == false);
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                             foreach (var item in tintuc)
                           {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <!-- Single News Area -->
                            <div class=""single-blog-post d-flex style-4 mb-30"">
                                <!-- Blog Thumbnail -->
                                <div class=""blog-thumbnail"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16292904e7618ee7227e4b321caeba63d2a3e36f1aad069200ef22096aca01f221135", async() => {
                    WriteLiteral("<img");
                    BeginWriteAttribute("src", " src=\"", 6590, "\"", 6607, 1);
#nullable restore
#line 116 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
WriteAttributeValue("", 6596, item.AnhTt, 6596, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("alt", " alt=\"", 6608, "\"", 6614, 0);
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                              WriteLiteral(item.MaTt);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n                                </div>\r\n\r\n                                <!-- Blog Content -->\r\n                                <div class=\"blog-content\">\r\n                                    <span class=\"post-date\">");
#nullable restore
#line 121 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                       Write(item.CreateDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16292904e7618ee7227e4b321caeba63d2a3e36f1aad069200ef22096aca01f224470", async() => {
#nullable restore
#line 122 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                                                                   Write(item.TenTt);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                                                              WriteLiteral(item.MaTt);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 125 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Views\TinTuc\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanDoGo.Models.TinTuc> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
