#pragma checksum "G:\Course\ASP.NET Core Advance\Source\E21\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa07e5226834a7ebf9023d7ccee0b909fd002d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_Home_Index), @"mvc.1.0.view", @"/Areas/UserPanel/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/UserPanel/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_UserPanel_Views_Home_Index))]
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
#line 1 "G:\Course\ASP.NET Core Advance\Source\E21\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Home\Index.cshtml"
using TopLearn.Core.Convertors;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa07e5226834a7ebf9023d7ccee0b909fd002d00", @"/Areas/UserPanel/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.Core.DTOs.InformationUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SideBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\Course\ASP.NET Core Advance\Source\E21\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "پنل کاربری "+User.Identity.Name;

#line default
#line hidden
            BeginContext(151, 408, true);
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">تاپ لرن</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> پنل کاربری </li>
        </ul>
    </nav>
</div>

<main>
    <div class=""container"">
        <div class=""user-account"">
            <div class=""row"">
                ");
            EndContext();
            BeginContext(559, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa07e5226834a7ebf9023d7ccee0b909fd002d004243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(584, 487, true);
            WriteLiteral(@"
                <div class=""col-md-9 col-sm-8 col-xs-12"">
                    <section class=""user-account-content"">
                        <header><h1> داشبورد </h1></header>
                        <div class=""inner"">
                            <div class=""account-information"">
                                <h3> اطلاعات کاربری </h3>
                                <ul>
                                    <li> <i class=""zmdi zmdi-assignment-account""></i> نام کاربری :  ");
            EndContext();
            BeginContext(1072, 14, false);
#line 28 "G:\Course\ASP.NET Core Advance\Source\E21\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                                               Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 89, true);
            WriteLiteral(" </li>\r\n                                    <li> <i class=\"zmdi zmdi-email\"></i> ایمیل : ");
            EndContext();
            BeginContext(1176, 11, false);
#line 29 "G:\Course\ASP.NET Core Advance\Source\E21\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                            Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 104, true);
            WriteLiteral(" </li>\r\n                                    <li> <i class=\"zmdi zmdi-calendar-check\"></i> تاریخ عضویت : ");
            EndContext();
            BeginContext(1292, 29, false);
#line 30 "G:\Course\ASP.NET Core Advance\Source\E21\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                                           Write(Model.RegisterDate.ToShamsi());

#line default
#line hidden
            EndContext();
            BeginContext(1321, 97, true);
            WriteLiteral(" </li>\r\n                                    <li> <i class=\"zmdi zmdi-account\"></i> موجودی حساب : ");
            EndContext();
            BeginContext(1419, 12, false);
#line 31 "G:\Course\ASP.NET Core Advance\Source\E21\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                                    Write(Model.Wallet);

#line default
#line hidden
            EndContext();
            BeginContext(1431, 234, true);
            WriteLiteral(" تومان </li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </section>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.Core.DTOs.InformationUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
