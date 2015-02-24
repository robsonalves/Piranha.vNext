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

namespace Piranha.Areas.Manager.Views.CategoryMgr.Partial
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/CategoryMgr/Partial/EditCategory.cshtml")]
    public partial class EditCategory : System.Web.Mvc.WebViewPage<dynamic>
    {
        public EditCategory()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Manager\Views\CategoryMgr\Partial\EditCategory.cshtml"
  
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

WriteLiteral("></span></div>\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" id=\"addCategoryTitle\"");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n\t\t\t\t<h3");

WriteLiteral(" class=\"panel-title\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"glyphicon glyphicon-plus pull-right\"");

WriteLiteral("></span>\r\n\t\t\t\t\t<a");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" href=\"#addCategory\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(" aria-controls=\"addCategory\"");

WriteLiteral(" data-bind=\"text: panelTitle\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 15 "..\..\Areas\Manager\Views\CategoryMgr\Partial\EditCategory.cshtml"
                   Write(Piranha.Manager.Resources.Category.AddTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</a>\r\n\t\t\t\t</h3>\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" id=\"addCategory\"");

WriteLiteral(" class=\"panel-collapse collapse\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(" aria-labelledby=\"addCategoryTitle\"");

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

WriteLiteral(" data-bind=\"css: { \'has-error has-feedback\': titleValid() != true }\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 989), Tuple.Create("\"", 1055)
            
            #line 25 "..\..\Areas\Manager\Views\CategoryMgr\Partial\EditCategory.cshtml"
         , Tuple.Create(Tuple.Create("", 1003), Tuple.Create<System.Object, System.Int32>(Piranha.Manager.Resources.Category.TitlePlaceholder
            
            #line default
            #line hidden
, 1003), false)
);

WriteLiteral(" data-bind=\"value: title\"");

WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t<!-- ko if: !titleValid() -->\r\n\t\t\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"glyphicon glyphicon-remove form-control-feedback\"");

WriteLiteral("></span>\r\n\t\t\t\t\t\t\t\t\t<!-- /ko -->\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1374), Tuple.Create("\"", 1439)
            
            #line 33 "..\..\Areas\Manager\Views\CategoryMgr\Partial\EditCategory.cshtml"
         , Tuple.Create(Tuple.Create("", 1388), Tuple.Create<System.Object, System.Int32>(Piranha.Manager.Resources.Category.SlugPlaceholder
            
            #line default
            #line hidden
, 1388), false)
);

WriteLiteral(" data-bind=\"value: slug\"");

WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</form>\r\n\t\t\t\t</div>\r\n\t\t\t\t<" +
"div");

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

            
            #line 46 "..\..\Areas\Manager\Views\CategoryMgr\Partial\EditCategory.cshtml"
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

            
            #line 55 "..\..\Areas\Manager\Views\CategoryMgr\Partial\EditCategory.cshtml"
                       Write(Piranha.Manager.Resources.Global.Cancel);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t</button>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r" +
"\n");

        }
    }
}
#pragma warning restore 1591
