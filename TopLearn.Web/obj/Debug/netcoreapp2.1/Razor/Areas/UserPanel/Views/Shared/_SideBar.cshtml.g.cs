#pragma checksum "G:\Course\ASP.NET Core Advance\Source\E22\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1723c74ffaf47aa10a94645155359f7fdd37e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_Shared__SideBar), @"mvc.1.0.view", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/UserPanel/Views/Shared/_SideBar.cshtml", typeof(AspNetCore.Areas_UserPanel_Views_Shared__SideBar))]
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
#line 1 "G:\Course\ASP.NET Core Advance\Source\E22\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.DTOs;

#line default
#line hidden
#line 2 "G:\Course\ASP.NET Core Advance\Source\E22\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.Convertors;

#line default
#line hidden
#line 3 "G:\Course\ASP.NET Core Advance\Source\E22\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.Services.InterFaces;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1723c74ffaf47aa10a94645155359f7fdd37e5", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(137, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "G:\Course\ASP.NET Core Advance\Source\E22\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
   
    SideBarUserPanelViewModel user = _UserService.GetSideBarUserPanelData(User.Identity.Name);

#line default
#line hidden
            BeginContext(243, 149, true);
            WriteLiteral("<div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n    <aside>\r\n\r\n        <div class=\"avatar-layer\">\r\n            <div class=\"img-layer\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 392, "\"", 399, 0);
            EndWriteAttribute();
            BeginContext(400, 78, true);
            WriteLiteral(" class=\"change-image\"><i class=\"zmdi zmdi-edit\"></i></a>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 478, "\"", 511, 2);
            WriteAttributeValue("", 484, "/UserAvatar/", 484, 12, true);
#line 15 "G:\Course\ASP.NET Core Advance\Source\E22\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
WriteAttributeValue("", 496, user.ImageName, 496, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(512, 80, true);
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"detail\">\r\n                <span> ");
            EndContext();
            BeginContext(593, 13, false);
#line 18 "G:\Course\ASP.NET Core Advance\Source\E22\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
                  Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(606, 41, true);
            WriteLiteral(" </span>\r\n                <span> عضویت : ");
            EndContext();
            BeginContext(648, 28, false);
#line 19 "G:\Course\ASP.NET Core Advance\Source\E22\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
                          Write(user.RegisterDate.ToShamsi());

#line default
#line hidden
            EndContext();
            BeginContext(676, 522, true);
            WriteLiteral(@" </span>
            </div>
        </div>

        <section>
            <header><h3> میز کار </h3></header>
            <div class=""inner"">
                <ul>
                    <li><a href=""/UserPanel""> مشاهده حساب کابری </a></li>
                    <li><a href=""/UserPanel/EditProfile""> ویرایش حساب کابری </a></li>
                    <li><a href=""/UserPanel/ChangePassword""> تغییر رمز عبور </a></li>
                    <li><a href=""/UserPanel/Wallet""> کیف پول شما </a></li>
                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1198, "\"", 1205, 0);
            EndWriteAttribute();
            BeginContext(1206, 190, true);
            WriteLiteral("> تنظیمات حساب کاربری </a></li>\r\n                    <li><a href=\"/Logout\"> خروج از حساب کاربری </a></li>\r\n                </ul>\r\n            </div>\r\n        </section>\r\n    </aside>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService _UserService { get; private set; }
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
