#pragma checksum "G:\Course\ASP.NET Core Advance\Source\E28\TopLearn\TopLearn.Web\Pages\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5127968f51f176bfadb5a9529ae1e60ea59007dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Index.cshtml", typeof(AspNetCore.Pages_Admin_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5127968f51f176bfadb5a9529ae1e60ea59007dc", @"/Pages/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 24060, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">Dashboard</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->
<div class=""row"">
    <div class=""col-lg-8"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-bar-chart-o fa-fw""></i> Area Chart Example
                <div class=""pull-right"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default btn-xs dropdown-toggle"" data-toggle=""dropdown"">
                            Actions
                            <span class=""caret""></span>
                        </button>
                        <ul class=""dropdown-menu pull-right"" role=""menu"">
                            <li>
                                <a href=""#"">Action</a>
                            </li>
                            <li>
                                <a href=""#"">Another action</a>
                         ");
            WriteLiteral(@"   </li>
                            <li>
                                <a href=""#"">Something else here</a>
                            </li>
                            <li class=""divider""></li>
                            <li>
                                <a href=""#"">Separated link</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div id=""morris-area-chart""></div>
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-bar-chart-o fa-fw""></i> Bar Chart Example
                <div class=""pull-left"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default btn-xs dropdown-toggle"" data-toggle=""dropdown""");
            WriteLiteral(@">
                            Actions
                            <span class=""caret""></span>
                        </button>
                        <ul class=""dropdown-menu pull-right"" role=""menu"">
                            <li>
                                <a href=""#"">Action</a>
                            </li>
                            <li>
                                <a href=""#"">Another action</a>
                            </li>
                            <li>
                                <a href=""#"">Something else here</a>
                            </li>
                            <li class=""divider""></li>
                            <li>
                                <a href=""#"">Separated link</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""row"">
                   ");
            WriteLiteral(@" <div class=""col-lg-4"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered table-hover table-striped"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Date</th>
                                        <th>Time</th>
                                        <th>Amount</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>3326</td>
                                        <td>10/21/2013</td>
                                        <td>3:29 PM</td>
                                        <td>$321.33</td>
                                    </tr>
                                    <tr>
                                        <td>3325</td>
         ");
            WriteLiteral(@"                               <td>10/21/2013</td>
                                        <td>3:20 PM</td>
                                        <td>$234.34</td>
                                    </tr>
                                    <tr>
                                        <td>3324</td>
                                        <td>10/21/2013</td>
                                        <td>3:03 PM</td>
                                        <td>$724.17</td>
                                    </tr>
                                    <tr>
                                        <td>3323</td>
                                        <td>10/21/2013</td>
                                        <td>3:00 PM</td>
                                        <td>$23.71</td>
                                    </tr>
                                    <tr>
                                        <td>3322</td>
                                        <td>10/21/2013</td>
                      ");
            WriteLiteral(@"                  <td>2:49 PM</td>
                                        <td>$8345.23</td>
                                    </tr>
                                    <tr>
                                        <td>3321</td>
                                        <td>10/21/2013</td>
                                        <td>2:23 PM</td>
                                        <td>$245.12</td>
                                    </tr>
                                    <tr>
                                        <td>3320</td>
                                        <td>10/21/2013</td>
                                        <td>2:15 PM</td>
                                        <td>$5663.54</td>
                                    </tr>
                                    <tr>
                                        <td>3319</td>
                                        <td>10/21/2013</td>
                                        <td>2:13 PM</td>
                                   ");
            WriteLiteral(@"     <td>$943.45</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <!-- /.table-responsive -->
                    </div>
                    <!-- /.col-lg-4 (nested) -->
                    <div class=""col-lg-8"">
                        <div id=""morris-bar-chart""></div>
                    </div>
                    <!-- /.col-lg-8 (nested) -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-clock-o fa-fw""></i> Timeline
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <ul class=""timeline"">
                    <li>
                        <div class=""timeline-badge"">
                    ");
            WriteLiteral(@"        <i class=""fa fa-check""></i>
                        </div>
                        <div class=""timeline-panel"">
                            <div class=""timeline-heading"">
                                <h4 class=""timeline-title"">Timeline Event</h4>
                                <p>
                                    <small class=""text-muted""><i class=""fa fa-time""></i> 11 hours ago via Twitter</small>
                                </p>
                            </div>
                            <div class=""timeline-body"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel justo eu mi scelerisque vulputate. Aliquam in metus eu lectus aliquet egestas.</p>
                            </div>
                        </div>
                    </li>
                    <li class=""timeline-inverted"">
                        <div class=""timeline-badge warning"">
                            <i class=""fa fa-credit-card""></i>
            ");
            WriteLiteral(@"            </div>
                        <div class=""timeline-panel"">
                            <div class=""timeline-heading"">
                                <h4 class=""timeline-title"">Timeline Event</h4>
                            </div>
                            <div class=""timeline-body"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel justo eu mi scelerisque vulputate. Aliquam in metus eu lectus aliquet egestas.</p>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel justo eu mi scelerisque vulputate. Aliquam in metus eu lectus aliquet egestas.</p>
                            </div>
                        </div>
                    </li>
                    <li>
                        <div class=""timeline-badge danger"">
                            <i class=""fa fa-credit-card""></i>
                        </div>
                        <div class=""timeline-panel"">
              ");
            WriteLiteral(@"              <div class=""timeline-heading"">
                                <h4 class=""timeline-title"">Timeline Event</h4>
                            </div>
                            <div class=""timeline-body"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel justo eu mi scelerisque vulputate. Aliquam in metus eu lectus aliquet egestas.</p>
                            </div>
                        </div>
                    </li>
                    <li class=""timeline-inverted"">
                        <div class=""timeline-panel"">
                            <div class=""timeline-heading"">
                                <h4 class=""timeline-title"">Timeline Event</h4>
                            </div>
                            <div class=""timeline-body"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel justo eu mi scelerisque vulputate. Aliquam in metus eu lectus aliquet egestas.</p>");
            WriteLiteral(@"
                            </div>
                        </div>
                    </li>
                    <li>
                        <div class=""timeline-badge info"">
                            <i class=""fa fa-save""></i>
                        </div>
                        <div class=""timeline-panel"">
                            <div class=""timeline-heading"">
                                <h4 class=""timeline-title"">Timeline Event</h4>
                            </div>
                            <div class=""timeline-body"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel justo eu mi scelerisque vulputate. Aliquam in metus eu lectus aliquet egestas.</p>
                                <hr>
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-primary btn-sm dropdown-toggle"" data-toggle=""dropdown"">
                                        <i class=""fa fa-c");
            WriteLiteral(@"og""></i>
                                        <span class=""caret""></span>
                                    </button>
                                    <ul class=""dropdown-menu"" role=""menu"">
                                        <li>
                                            <a href=""#"">Action</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Another action</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Something else here</a>
                                        </li>
                                        <li class=""divider""></li>
                                        <li>
                                            <a href=""#"">Separated link</a>
                                        </li>
                                    </ul>
                                </div>");
            WriteLiteral(@"
                            </div>
                        </div>
                    </li>
                    <li>
                        <div class=""timeline-panel"">
                            <div class=""timeline-heading"">
                                <h4 class=""timeline-title"">Timeline Event</h4>
                            </div>
                            <div class=""timeline-body"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel justo eu mi scelerisque vulputate. Aliquam in metus eu lectus aliquet egestas.</p>
                            </div>
                        </div>
                    </li>
                    <li class=""timeline-inverted"">
                        <div class=""timeline-badge success"">
                            <i class=""fa fa-thumbs-up""></i>
                        </div>
                        <div class=""timeline-panel"">
                            <div class=""timeline-heading"">
             ");
            WriteLiteral(@"                   <h4 class=""timeline-title"">Timeline Event</h4>
                            </div>
                            <div class=""timeline-body"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel justo eu mi scelerisque vulputate. Aliquam in metus eu lectus aliquet egestas.</p>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-8 -->
    <div class=""col-lg-4"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-bell fa-fw""></i> Notifications Panel
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""list-group"">
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-comment ");
            WriteLiteral(@"fa-fw""></i> New Comment
                        <span class=""pull-left text-muted small"">
                            <em>4 minutes ago</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-twitter fa-fw""></i> 3 New Followers
                        <span class=""pull-left text-muted small"">
                            <em>12 minutes ago</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-envelope fa-fw""></i> Message Sent
                        <span class=""pull-left text-muted small"">
                            <em>27 minutes ago</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-tasks fa-fw""></i> New Task
                        <span class=""pull-left text-muted small"">
  ");
            WriteLiteral(@"                          <em>43 minutes ago</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-upload fa-fw""></i> Server Rebooted
                        <span class=""pull-left text-muted small"">
                            <em>11:32 AM</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-bolt fa-fw""></i> Server Crashed!
                        <span class=""pull-left text-muted small"">
                            <em>11:13 AM</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-warning fa-fw""></i> Server Not Responding
                        <span class=""pull-left text-muted small"">
                            <em>10:57 AM</em>
                        </span>
              ");
            WriteLiteral(@"      </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-shopping-cart fa-fw""></i> New Order Placed
                        <span class=""pull-left text-muted small"">
                            <em>9:49 AM</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-money fa-fw""></i> Payment Received
                        <span class=""pull-left text-muted small"">
                            <em>Yesterday</em>
                        </span>
                    </a>
                </div>
                <!-- /.list-group -->
                <a href=""#"" class=""btn btn-default btn-block"">View All Alerts</a>
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-bar-chart-o fa-fw""></i> Donut C");
            WriteLiteral(@"hart Example
            </div>
            <div class=""panel-body"">
                <div id=""morris-donut-chart""></div>
                <a href=""#"" class=""btn btn-default btn-block"">View Details</a>
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
        <div class=""chat-panel panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-comments fa-fw""></i>
                Chat
                <div class=""btn-group pull-right"">
                    <button type=""button"" class=""btn btn-default btn-xs dropdown-toggle"" data-toggle=""dropdown"">
                        <i class=""fa fa-chevron-down""></i>
                    </button>
                    <ul class=""dropdown-menu slidedown"">
                        <li>
                            <a href=""#"">
                                <i class=""fa fa-refresh fa-fw""></i> Refresh
                            </a>
                        </li>
                      ");
            WriteLiteral(@"  <li>
                            <a href=""#"">
                                <i class=""fa fa-check-circle fa-fw""></i> Available
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <i class=""fa fa-times fa-fw""></i> Busy
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <i class=""fa fa-clock-o fa-fw""></i> Away
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#"">
                                <i class=""fa fa-sign-out fa-fw""></i> Sign Out
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- /.panel-heading -->
            <div class=""panel");
            WriteLiteral(@"-body"">
                <ul class=""chat"">
                    <li class=""left clearfix"">
                        <span class=""chat-img pull-left"">
                            <img src=""http://placehold.it/50/55C1E7/fff"" alt=""User Avatar"" class=""img-circle"" />
                        </span>
                        <div class=""chat-body clearfix"">
                            <div class=""header"">
                                <strong class=""primary-font"">Jack Sparrow</strong>
                                <small class=""pull-left text-muted"">
                                    <i class=""fa fa-clock-o fa-fw""></i> 12 mins ago
                                </small>
                            </div>
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales.
                            </p>
                        </div>
                    </li>
                   ");
            WriteLiteral(@" <li class=""right clearfix"">
                        <span class=""chat-img pull-right"">
                            <img src=""http://placehold.it/50/FA6F57/fff"" alt=""User Avatar"" class=""img-circle"" />
                        </span>
                        <div class=""chat-body clearfix"">
                            <div class=""header"">
                                <strong class=""primary-font"">Jack Sparrow</strong>
                                <small class=""pull-left text-muted"">
                                    <i class=""fa fa-clock-o fa-fw""></i> 12 mins ago
                                </small>
                            </div>
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales.
                            </p>
                        </div>
                    </li>
                    <li class=""left clearfix"">
                        <span cl");
            WriteLiteral(@"ass=""chat-img pull-left"">
                            <img src=""http://placehold.it/50/55C1E7/fff"" alt=""User Avatar"" class=""img-circle"" />
                        </span>
                        <div class=""chat-body clearfix"">
                            <div class=""header"">
                                <strong class=""primary-font"">Jack Sparrow</strong>
                                <small class=""pull-left text-muted"">
                                    <i class=""fa fa-clock-o fa-fw""></i> 14 mins ago
                                </small>
                            </div>
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales.
                            </p>
                        </div>
                    </li>
                    <li class=""right clearfix"">
                        <span class=""chat-img pull-right"">
                            <img s");
            WriteLiteral(@"rc=""http://placehold.it/50/FA6F57/fff"" alt=""User Avatar"" class=""img-circle"" />
                        </span>
                        <div class=""chat-body clearfix"">
                            <div class=""header"">
                                <strong class=""primary-font"">Jack Sparrow</strong>
                                <small class=""pull-left text-muted"">
                                    <i class=""fa fa-clock-o fa-fw""></i> 12 mins ago
                                </small>
                            </div>
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare dolor, quis ullamcorper ligula sodales.
                            </p>
                        </div>
                    </li>
                </ul>
            </div>
            <!-- /.panel-body -->
            <div class=""panel-footer"">
                <div class=""input-group"">
                    <input id=""btn-input"" t");
            WriteLiteral(@"ype=""text"" class=""form-control input-sm"" placeholder=""Type your message here..."" />
                    <span class=""input-group-btn"">
                        <button class=""btn btn-warning btn-sm"" id=""btn-chat"">
                            Send
                        </button>
                    </span>
                </div>
            </div>
            <!-- /.panel-footer -->
        </div>
        <!-- /.panel .chat-panel -->
    </div>
    <!-- /.col-lg-4 -->
</div>
<!-- /.row -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.Web.Pages.Admin.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearn.Web.Pages.Admin.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearn.Web.Pages.Admin.IndexModel>)PageContext?.ViewData;
        public TopLearn.Web.Pages.Admin.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
