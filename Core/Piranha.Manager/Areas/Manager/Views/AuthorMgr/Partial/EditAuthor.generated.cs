﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.AuthorMgr.Partial
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/AuthorMgr/Partial/EditAuthor.cshtml")]
    public partial class EditAuthor : System.Web.Mvc.WebViewPage<dynamic>
    {
        public EditAuthor()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Manager\Views\AuthorMgr\Partial\EditAuthor.cshtml"
  
	Layout = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t<div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"panel panel-primary panel-add\"");

WriteLiteral(" >\r\n\t\t\t<div");

WriteLiteral(" class=\"notification\"");

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"icon\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-ok-circle\"");

WriteLiteral("></span></div>\r\n\t\t\t</div>\r\n\t\t\t<!-- ko if: gravatarUrl -->\r\n\t\t\t<img");

WriteLiteral(" class=\"gravatar\"");

WriteLiteral(" data-bind=\"attr: { src: gravatarUrl }\"");

WriteLiteral(" />\r\n\t\t\t<!-- /ko -->\r\n\t\t\t<div");

WriteLiteral(" id=\"addAuthorTitle\"");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n\t\t\t\t<h3");

WriteLiteral(" class=\"panel-title\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"glyphicon glyphicon-plus pull-right\"");

WriteLiteral("></span>\r\n\t\t\t\t\t<a");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" href=\"#addAuthor\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(" aria-controls=\"addAuthor\"");

WriteLiteral(" data-bind=\"text: title\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 18 "..\..\Areas\Manager\Views\AuthorMgr\Partial\EditAuthor.cshtml"
                   Write(Piranha.Manager.Resources.Author.AddTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</a>\r\n\t\t\t\t</h3>\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" id=\"addAuthor\"");

WriteLiteral(" class=\"panel-collapse collapse\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(" aria-labelledby=\"addAuthorTitle\"");

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n\t\t\t\t\t<form");

WriteLiteral(" role=\"form\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" data-bind=\"css: { \'has-error has-feedback\': nameValid() != true }\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<input");

WriteLiteral(" id=\"authorName\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1104), Tuple.Create("\"", 1167)
            
            #line 28 "..\..\Areas\Manager\Views\AuthorMgr\Partial\EditAuthor.cshtml"
                         , Tuple.Create(Tuple.Create("", 1118), Tuple.Create<System.Object, System.Int32>(Piranha.Manager.Resources.Author.NamePlaceholder
            
            #line default
            #line hidden
, 1118), false)
);

WriteLiteral(" data-bind=\"value: name\"");

WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t<!-- ko if: !nameValid() -->\r\n\t\t\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"glyphicon glyphicon-remove form-control-feedback\"");

WriteLiteral("></span>\r\n\t\t\t\t\t\t\t\t\t<!-- /ko -->\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"col-sm-5\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" data-bind=\"css: { \'has-error has-feedback\': emailValid() != true }\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<input");

WriteLiteral(" id=\"authorEmail\"");

WriteLiteral(" name=\"Email\"");

WriteLiteral(" class=\"form-control\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1570), Tuple.Create("\"", 1634)
            
            #line 36 "..\..\Areas\Manager\Views\AuthorMgr\Partial\EditAuthor.cshtml"
                           , Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Piranha.Manager.Resources.Author.EmailPlaceholder
            
            #line default
            #line hidden
, 1584), false)
);

WriteLiteral(" data-bind=\"value: email\"");

WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t<!-- ko if: !emailValid() -->\r\n\t\t\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"glyphicon glyphicon-remove form-control-feedback\"");

WriteLiteral("></span>\r\n\t\t\t\t\t\t\t\t\t<!-- /ko -->\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t" +
"\t\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<textarea");

WriteLiteral(" id=\"authorDescription\"");

WriteLiteral(" class=\"form-control editor\"");

WriteLiteral(" data-bind=\"text: description\"");

WriteLiteral("></textarea>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</form>\r\n\t\t\t\t</di" +
"v>\r\n\t\t\t\t<div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n\t\t\t\t\t<!-- Save -->\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-labeled btn-success\"");

WriteLiteral(" data-bind=\"click: save\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"btn-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<i");

WriteLiteral(" class=\"glyphicon glyphicon-ok\"");

WriteLiteral("></i>\r\n\t\t\t\t\t\t\t</span>\r\n");

WriteLiteral("\t\t\t\t\t\t\t");

            
            #line 59 "..\..\Areas\Manager\Views\AuthorMgr\Partial\EditAuthor.cshtml"
                       Write(Piranha.Manager.Resources.Global.Save);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t</button>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<!-- Cancel -->\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-labeled btn-danger\"");

WriteLiteral(" data-bind=\"click: clear\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"btn-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></i>\r\n\t\t\t\t\t\t\t</span>\r\n");

WriteLiteral("\t\t\t\t\t\t\t");

            
            #line 68 "..\..\Areas\Manager\Views\AuthorMgr\Partial\EditAuthor.cshtml"
                       Write(Piranha.Manager.Resources.Global.Cancel);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t</button>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r" +
"\n");

        }
    }
}
#pragma warning restore 1591
