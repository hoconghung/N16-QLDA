#pragma checksum "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f7834a05e17f10d290564cb81344faeb0594ac6caf0ad364b8eb5b6c7124bd48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCustomers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCustomers/Index.cshtml")]
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
#line 1 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanDoGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanDoGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f7834a05e17f10d290564cb81344faeb0594ac6caf0ad364b8eb5b6c7124bd48", @"/Areas/Admin/Views/AdminCustomers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"075d4e09ea2cbca4c6bc35fc1f408ad664bf60b53bcf505e741ff6d67678bb19", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminCustomers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBanDoGo.Models.KhachHang>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:12px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables-bt5.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7834a05e17f10d290564cb81344faeb0594ac6caf0ad364b8eb5b6c7124bd485381", async() => {
                WriteLiteral(" \r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/5.1.3/css/bootstrap.min.css\">\r\n <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.11.5/css/dataTables.bootstrap5.min.css\">\r\n");
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
            WriteLiteral(@"


<div class=""col-12"">
          <div class=""card mb-4"">
            <div class=""card-header pb-0"">
              <h4>Danh Sách Khách Hàng</h4>
            </div>
       
            <div class=""card-body px-0 pt-0 pb-2"" >
              <div class=""table-responsive p-0"">
                <table id=""example"" class=""table align-items-center justify-content-center mb-0 table-striped"" style=""font-size:20px;"">
                  <thead>
                    <tr>
                      <th class=""text-uppercase text-secondary text-xxs font-weight-bolder "">Khách Hàng</th>
                      <th class=""text-uppercase text-secondary text-xxs font-weight-bolder "">Ngày Sinh</th>
                      <th class=""text-uppercase text-secondary text-xxs font-weight-bolder "">Giới Tính</th>
                      <th class=""text-uppercase text-secondary text-xxs font-weight-bolder "">Email</th>
                      <th class=""text-uppercase text-secondary text-xxs font-weight-bolder "">Số Điện Thoại</th>
    ");
            WriteLiteral("                  <th class=\"text-uppercase text-secondary text-xxs font-weight-bolder \">Ngày Tạo</th>\r\n                      <th></th>\r\n                    </tr>\r\n                  </thead>\r\n                  \r\n                  <tbody>\r\n");
#nullable restore
#line 38 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                       foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <tr>\r\n                      <td>\r\n                        <div class=\"d-flex px-2\">\r\n                          <div>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1889, "\"", 1939, 1);
#nullable restore
#line 43 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
WriteAttributeValue("", 1895, Html.DisplayFor(modelItem => item.AvatarKh), 1895, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"avatar avatar-sm me-2\">\r\n                          </div>\r\n                          <div class=\"my-auto\">\r\n                            <h6 class=\"mb-0 text-sm font-weight-bold\" style=\"font-size:12px;\">");
#nullable restore
#line 46 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.TenKh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                          </div>\r\n                        </div>\r\n                      </td>\r\n                      <td>\r\n                        <span class=\"font-weight-bold\" style=\"font-size:12px;\">");
#nullable restore
#line 51 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                                                                          Write(item.Ngaysinh.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                      </td>\r\n                      <td>\r\n                        <span class=\"font-weight-bold\" style=\"font-size:12px;\">");
#nullable restore
#line 54 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                      </td>\r\n                      <td>\r\n                        <span class=\"font-weight-bold\" style=\"font-size:12px;\">");
#nullable restore
#line 57 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                      </td>\r\n                      <td>\r\n                        <span class=\"font-weight-bold\" style=\"font-size:12px;\">");
#nullable restore
#line 60 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                      </td>\r\n                      <td>\r\n                        <span class=\"font-weight-bold\" style=\"font-size:12px;\">");
#nullable restore
#line 63 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                      </td>\r\n                      <td class=\"align-middle\">\r\n                 \r\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7834a05e17f10d290564cb81344faeb0594ac6caf0ad364b8eb5b6c7124bd4811962", async() => {
                WriteLiteral("Xem");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                                                WriteLiteral(item.MaKh);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                      </td>\r\n                    </tr>\r\n");
#nullable restore
#line 70 "D:\BaiTapLon\BTL ASP NET CORE MVC\WebBanDoGo\Areas\Admin\Views\AdminCustomers\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
<script src=""https://code.jquery.com/jquery-3.5.1.js""></script>
<script src=""https://cdn.datatables.net/1.11.5/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.11.5/js/dataTables.bootstrap5.min.js""></script>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7834a05e17f10d290564cb81344faeb0594ac6caf0ad364b8eb5b6c7124bd4814992", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBanDoGo.Models.KhachHang>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
