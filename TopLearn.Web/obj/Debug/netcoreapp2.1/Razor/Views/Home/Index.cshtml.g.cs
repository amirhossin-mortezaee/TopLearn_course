#pragma checksum "G:\Course\ASP.NET Core Advance\Source\E23\TopLearn\TopLearn.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e78d1678d3d6a396cbcaa335f3f6e74a533f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e78d1678d3d6a396cbcaa335f3f6e74a533f40", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Course\ASP.NET Core Advance\Source\E23\TopLearn\TopLearn.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "خانه";

#line default
#line hidden
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SearchBox", async() => {
                BeginContext(65, 26, true);
                WriteLiteral("\r\n    <header>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 91, "\"", 98, 0);
                EndWriteAttribute();
                BeginContext(99, 285, true);
                WriteLiteral(@" class=""logo""><img src=""/images/logo.png""></a>
        <h1> با اساتید مجرب و کارآزموده در خودآموز تاپ لرن </h1>
        <h2> آموزش ببینید ، تجربه کسب کنید و بازار کار شوید </h2>
        <h3> با کمترین هزینه خودت یاد بگیر </h3>
    </header>
    <div class=""search-form"">
        ");
                EndContext();
                BeginContext(384, 166, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6e78d1678d3d6a396cbcaa335f3f6e74a533f404102", async() => {
                    BeginContext(390, 32, true);
                    WriteLiteral("\r\n            <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("name", " name=\"", 422, "\"", 429, 0);
                    EndWriteAttribute();
                    BeginContext(430, 113, true);
                    WriteLiteral(" placeholder=\"چی دوست داری یاد بگیری ؟\">\r\n            <button><i class=\"zmdi zmdi-search\"></i></button>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(550, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(567, 182, true);
            WriteLiteral("<main id=\"home-page\">\r\n    <div class=\"container\">\r\n        <section class=\"terms-items\">\r\n            <header>\r\n                <h2> آخرین دوره های تاپ لرن </h2>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 749, "\"", 756, 0);
            EndWriteAttribute();
            BeginContext(757, 245, true);
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n            </header>\r\n            <div class=\"row\">\r\n                <!-- col -->\r\n                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n                    <article>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1002, "\"", 1009, 0);
            EndWriteAttribute();
            BeginContext(1010, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/1.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1094, "\"", 1101, 0);
            EndWriteAttribute();
            BeginContext(1102, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1483, "\"", 1490, 0);
            EndWriteAttribute();
            BeginContext(1491, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/2.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1575, "\"", 1582, 0);
            EndWriteAttribute();
            BeginContext(1583, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1964, "\"", 1971, 0);
            EndWriteAttribute();
            BeginContext(1972, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/3.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2056, "\"", 2063, 0);
            EndWriteAttribute();
            BeginContext(2064, 388, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2452, "\"", 2459, 0);
            EndWriteAttribute();
            BeginContext(2460, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/4.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2544, "\"", 2551, 0);
            EndWriteAttribute();
            BeginContext(2552, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2933, "\"", 2940, 0);
            EndWriteAttribute();
            BeginContext(2941, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/5.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3025, "\"", 3032, 0);
            EndWriteAttribute();
            BeginContext(3033, 387, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3420, "\"", 3427, 0);
            EndWriteAttribute();
            BeginContext(3428, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/6.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3512, "\"", 3519, 0);
            EndWriteAttribute();
            BeginContext(3520, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3901, "\"", 3908, 0);
            EndWriteAttribute();
            BeginContext(3909, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/7.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3993, "\"", 4000, 0);
            EndWriteAttribute();
            BeginContext(4001, 387, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4388, "\"", 4395, 0);
            EndWriteAttribute();
            BeginContext(4396, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/8.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4480, "\"", 4487, 0);
            EndWriteAttribute();
            BeginContext(4488, 411, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
            </div>
        </section>

        <hr>

        <section class=""terms-items"">
            <header>
                <h2> دوره های محبوب تاپ لرن </h2>
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4899, "\"", 4906, 0);
            EndWriteAttribute();
            BeginContext(4907, 245, true);
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n            </header>\r\n            <div class=\"row\">\r\n                <!-- col -->\r\n                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n                    <article>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5152, "\"", 5159, 0);
            EndWriteAttribute();
            BeginContext(5160, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/1.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5244, "\"", 5251, 0);
            EndWriteAttribute();
            BeginContext(5252, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5633, "\"", 5640, 0);
            EndWriteAttribute();
            BeginContext(5641, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/2.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5725, "\"", 5732, 0);
            EndWriteAttribute();
            BeginContext(5733, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6114, "\"", 6121, 0);
            EndWriteAttribute();
            BeginContext(6122, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/3.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6206, "\"", 6213, 0);
            EndWriteAttribute();
            BeginContext(6214, 388, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6602, "\"", 6609, 0);
            EndWriteAttribute();
            BeginContext(6610, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/4.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6694, "\"", 6701, 0);
            EndWriteAttribute();
            BeginContext(6702, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7083, "\"", 7090, 0);
            EndWriteAttribute();
            BeginContext(7091, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/5.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7175, "\"", 7182, 0);
            EndWriteAttribute();
            BeginContext(7183, 387, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7570, "\"", 7577, 0);
            EndWriteAttribute();
            BeginContext(7578, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/6.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7662, "\"", 7669, 0);
            EndWriteAttribute();
            BeginContext(7670, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8051, "\"", 8058, 0);
            EndWriteAttribute();
            BeginContext(8059, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/7.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8143, "\"", 8150, 0);
            EndWriteAttribute();
            BeginContext(8151, 387, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8538, "\"", 8545, 0);
            EndWriteAttribute();
            BeginContext(8546, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/8.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8630, "\"", 8637, 0);
            EndWriteAttribute();
            BeginContext(8638, 286, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
            </div>
        </section>
    </div>
</main>

");
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
