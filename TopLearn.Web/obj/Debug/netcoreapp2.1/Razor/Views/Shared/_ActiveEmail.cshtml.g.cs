#pragma checksum "G:\Course\ASP.NET Core Advance\Source\E13\TopLearn\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "952b77830e5221e461d291a16fd2e19e404a41cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ActiveEmail), @"mvc.1.0.view", @"/Views/Shared/_ActiveEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ActiveEmail.cshtml", typeof(AspNetCore.Views_Shared__ActiveEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"952b77830e5221e461d291a16fd2e19e404a41cf", @"/Views/Shared/_ActiveEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ActiveEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.DataLayer.Entities.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 58, true);
            WriteLiteral("\r\n<div style=\"direction : rtl; padding : 20px;\">\r\n    <h2>");
            EndContext();
            BeginContext(105, 14, false);
#line 4 "G:\Course\ASP.NET Core Advance\Source\E13\TopLearn\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml"
   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(119, 131, true);
            WriteLiteral(" عزیز !</h2>\r\n    <p>با تشکر از ثبت نام شما در تاپ لرن ،جهت ادامه کار میبایست حساب کاربری خود را فعال کنید</p>\r\n    <p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 250, "\"", 319, 2);
            WriteAttributeValue("", 257, "http://localhost:59480/Account/ActiveAccount/", 257, 45, true);
#line 7 "G:\Course\ASP.NET Core Advance\Source\E13\TopLearn\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml"
WriteAttributeValue("", 302, Model.ActiveCode, 302, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(320, 45, true);
            WriteLiteral(">فعالسازی حساب کاربری</a>\r\n    </p>\r\n</div>\r\n");
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
