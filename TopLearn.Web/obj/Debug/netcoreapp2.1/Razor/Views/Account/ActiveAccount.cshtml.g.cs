#pragma checksum "G:\Course\ASP.NET Core Advance\Source\E23\TopLearn\TopLearn.Web\Views\Account\ActiveAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b2519079fc493f22a5e0c1c2113a566ad07689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ActiveAccount), @"mvc.1.0.view", @"/Views/Account/ActiveAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ActiveAccount.cshtml", typeof(AspNetCore.Views_Account_ActiveAccount))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b2519079fc493f22a5e0c1c2113a566ad07689", @"/Views/Account/ActiveAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ActiveAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Course\ASP.NET Core Advance\Source\E23\TopLearn\TopLearn.Web\Views\Account\ActiveAccount.cshtml"
  
    ViewData["Title"] = "فعالسازی";

#line default
#line hidden
            BeginContext(46, 266, true);
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
    <ul class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""/"">تاپ لرن</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">فعالسازی حساب کاربری</li>
    </ul>
</nav>


<div class=""container"">
");
            EndContext();
#line 15 "G:\Course\ASP.NET Core Advance\Source\E23\TopLearn\TopLearn.Web\Views\Account\ActiveAccount.cshtml"
     if (ViewBag.IsActive)
    {

#line default
#line hidden
            BeginContext(347, 199, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <p>حساب کاربری شما با موفقیت فعال شد</p>\r\n            <p>\r\n                <a href=\"/Login\">ورود به سایت</a>\r\n            </p>\r\n        </div>\r\n");
            EndContext();
#line 23 "G:\Course\ASP.NET Core Advance\Source\E23\TopLearn\TopLearn.Web\Views\Account\ActiveAccount.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(570, 118, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <p>حساب کاربری با مشخصات وارد شده یافت نشد</p>\r\n        </div>\r\n");
            EndContext();
#line 29 "G:\Course\ASP.NET Core Advance\Source\E23\TopLearn\TopLearn.Web\Views\Account\ActiveAccount.cshtml"
    }

#line default
#line hidden
            BeginContext(695, 8, true);
            WriteLiteral("\r\n</div>");
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
