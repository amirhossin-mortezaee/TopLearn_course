#pragma checksum "G:\Course\ASP.NET Core Advance\Source\E24\TopLearn\TopLearn.Web\Views\Shared\_ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84b14f29637a4879b17630483c2baee8e26db18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ForgotPassword), @"mvc.1.0.view", @"/Views/Shared/_ForgotPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ForgotPassword.cshtml", typeof(AspNetCore.Views_Shared__ForgotPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84b14f29637a4879b17630483c2baee8e26db18", @"/Views/Shared/_ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.DataLayer.Entities.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 58, true);
            WriteLiteral("\r\n<div style=\"direction : rtl; padding : 20px;\">\r\n    <h2>");
            EndContext();
            BeginContext(105, 14, false);
#line 4 "G:\Course\ASP.NET Core Advance\Source\E24\TopLearn\TopLearn.Web\Views\Shared\_ForgotPassword.cshtml"
   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(119, 112, true);
            WriteLiteral(" عزیز !</h2>\r\n    <p>\r\n        جهت بازیابی حساب کاربری خود روی لینک زیر کلیک کنید\r\n    </p>\r\n    <p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 231, "\"", 300, 2);
            WriteAttributeValue("", 238, "http://localhost:59480/Account/ResetPassword/", 238, 45, true);
#line 9 "G:\Course\ASP.NET Core Advance\Source\E24\TopLearn\TopLearn.Web\Views\Shared\_ForgotPassword.cshtml"
WriteAttributeValue("", 283, Model.ActiveCode, 283, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(301, 42, true);
            WriteLiteral(">بازیابی کلمه عبور</a>\r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.DataLayer.Entities.User.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
