#pragma checksum "G:\Course\ASP.NET Core Advance\Source\E29\TopLearn\TopLearn.Web\Pages\Admin\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d84f1957e987037b309e9d65a8a02ff6a93808"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/Index.cshtml", typeof(AspNetCore.Pages_Admin_Roles_Index), null)]
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
#line 3 "G:\Course\ASP.NET Core Advance\Source\E29\TopLearn\TopLearn.Web\Pages\Admin\Roles\Index.cshtml"
using TopLearn.Core.Convertors;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d84f1957e987037b309e9d65a8a02ff6a93808", @"/Pages/Admin/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "G:\Course\ASP.NET Core Advance\Source\E29\TopLearn\TopLearn.Web\Pages\Admin\Roles\Index.cshtml"
  
    ViewData["Title"] = "لیست نقش ها";

#line default
#line hidden
            BeginContext(137, 774, true);
            WriteLiteral(@"<style>
    #create {
        margin: 10px -11px 15px 41px;
    }
</style>
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">لیست نقش ها</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                لیست نقش ها سایت
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""row"">
                            <div class=""container"">
                                ");
            EndContext();
            BeginContext(911, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d84f1957e987037b309e9d65a8a02ff6a938085190", async() => {
                BeginContext(984, 15, true);
                WriteLiteral("افزودن نقش جدید");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1003, 540, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                        <thead>
                            <tr>
                                <td>عنوان نقش</td>
                                <td>دستورات</td>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 43 "G:\Course\ASP.NET Core Advance\Source\E29\TopLearn\TopLearn.Web\Pages\Admin\Roles\Index.cshtml"
                             foreach (var role in Model.RoleList)
                            {

#line default
#line hidden
            BeginContext(1641, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1720, 14, false);
#line 46 "G:\Course\ASP.NET Core Advance\Source\E29\TopLearn\TopLearn.Web\Pages\Admin\Roles\Index.cshtml"
                                   Write(role.RoleTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1734, 91, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1825, "\"", 1866, 2);
            WriteAttributeValue("", 1832, "/Admin/Roles/EditRole/", 1832, 22, true);
#line 48 "G:\Course\ASP.NET Core Advance\Source\E29\TopLearn\TopLearn.Web\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 1854, role.RoleId, 1854, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1867, 174, true);
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                            ویرایش\r\n                                        </a>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2041, "\"", 2084, 2);
            WriteAttributeValue("", 2048, "/Admin/Roles/DeleteRole/", 2048, 24, true);
#line 51 "G:\Course\ASP.NET Core Advance\Source\E29\TopLearn\TopLearn.Web\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 2072, role.RoleId, 2072, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2085, 210, true);
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                                            حذف\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 56 "G:\Course\ASP.NET Core Advance\Source\E29\TopLearn\TopLearn.Web\Pages\Admin\Roles\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2326, 229, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <!-- /.panel-body -->\r\n        </div>\r\n        <!-- /.panel -->\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.Web.Pages.Admin.Roles.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearn.Web.Pages.Admin.Roles.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearn.Web.Pages.Admin.Roles.IndexModel>)PageContext?.ViewData;
        public TopLearn.Web.Pages.Admin.Roles.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
