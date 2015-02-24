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

namespace Piranha.Areas.Manager.Views.PostMgr
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/PostMgr/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<Piranha.Manager.Models.Post.EditModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
DefineSection("head", () => {

WriteLiteral("\r\n\t<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n\t\t#Excerpt {\r\n\t\t\theight: 198px;\r\n\t\t}\r\n\t</style>\r\n");

});

WriteLiteral("\r\n");

DefineSection("script", () => {

WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 12 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
Write(Html.Partial("Partial/Editor"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\t<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n\t\t$(document).ready(function () {\r\n\t\t\t// Initialize select2\r\n\t\t\tvar categories" +
" = [\r\n");

            
            #line 18 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
				
            
            #line default
            #line hidden
            
            #line 18 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                 foreach (var cat in Model.Categories) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t");

WriteLiteral("\"");

            
            #line 19 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                          Write(cat.Text);

            
            #line default
            #line hidden
WriteLiteral("\",");

WriteLiteral("\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
					}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t];\r\n\t\t\t$(\'#SelectedCategories\').select2({ tags: categories, placeholder: \"Add " +
"some categories to your post\" });\r\n\r\n\t\t\t// Initialize comments\r\n\t\t\tvar comments " +
"= new manager.commentDialog(\'#comments\', \'");

            
            #line 25 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                                              Write(Url.Content("~/manager/post/comment"));

            
            #line default
            #line hidden
WriteLiteral("\', \'");

            
            #line 25 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                                                                                        Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n\r\n\t\t\t// Focus the first input box\r\n\t\t\t$(\'#Title\').focus();\r\n\t\t});\r\n\r\n\t\t// Se" +
"t submit action to publish\r\n\t\t$(document).on(\'click\', \'#submit-publish\', functio" +
"n () {\r\n\t\t\t$(\'#Action\').val(\'");

            
            #line 33 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                          Write((int)Piranha.Manager.Models.Post.EditModel.SubmitAction.Publish);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n\t\t\t$(\'form\').submit();\r\n\t\t});\r\n\r\n\t\t// Set submit action to upublish\r\n\t\t$(doc" +
"ument).on(\'click\', \'#submit-unpublish\', function () {\r\n\t\t\t$(\'#Action\').val(\'");

            
            #line 39 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                          Write((int)Piranha.Manager.Models.Post.EditModel.SubmitAction.Unpublish);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n\t\t\t$(\'form\').submit();\r\n\t\t});\r\n\t</script>\r\n");

});

WriteLiteral("\r\n");

            
            #line 45 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
 using (var form = Html.BeginForm("Save", "PostMgr", FormMethod.Post, new { @class = "form", @role = "form" })) {
	
            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                            
	
            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                              
	
            
            #line default
            #line hidden
            
            #line 48 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
Write(Html.HiddenFor(m => m.TypeId));

            
            #line default
            #line hidden
            
            #line 48 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                  
	
            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
Write(Html.HiddenFor(m => m.TypeName));

            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                    
	
            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
Write(Html.HiddenFor(m => m.Action));

            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                  


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t<!-- Actions -->\r\n\t\t<div");

WriteLiteral(" class=\"col-sm-12 buttons\"");

WriteLiteral(">\r\n\t\t\t<!-- Settings -->\r\n\t\t\t<div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-labeled btn-primary\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#mdSettings\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"btn-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<i");

WriteLiteral(" class=\"glyphicon glyphicon-cog\"");

WriteLiteral("></i>\r\n\t\t\t\t\t</span>\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 61 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
               Write(Piranha.Manager.Resources.Global.Settings);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</button>\r\n\t\t\t</div>\r\n\r\n\t\t\t<!-- Comments -->\r\n\t\t\t<div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-labeled btn-info\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#mdComments\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"btn-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<i");

WriteLiteral(" class=\"glyphicon glyphicon-comment\"");

WriteLiteral("></i>\r\n\t\t\t\t\t</span>\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 71 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
               Write(Piranha.Manager.Resources.Post.Comments);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</button>\r\n\t\t\t</div>\r\n\r\n\t\t\t<!-- Actions -->\r\n\t\t\t<div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n\t\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-labeled btn-success\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"btn-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<i");

WriteLiteral(" class=\"glyphicon glyphicon-ok\"");

WriteLiteral("></i>\r\n\t\t\t\t\t</span>\r\n");

            
            #line 81 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
					
            
            #line default
            #line hidden
            
            #line 81 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                     if (Model.Published.HasValue) {
						
            
            #line default
            #line hidden
            
            #line 82 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Piranha.Manager.Resources.Post.UpdatePost);

            
            #line default
            #line hidden
            
            #line 82 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                                                  
					} else {
						
            
            #line default
            #line hidden
            
            #line 84 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Piranha.Manager.Resources.Global.SaveDraft);

            
            #line default
            #line hidden
            
            #line 84 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                                                   
					}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t</button>\r\n\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-success dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span>\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Toggle Dropdown</span>\r\n\t\t\t\t</button>\r\n\t\t\t\t<ul");

WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");

WriteLiteral(" role=\"menu\"");

WriteLiteral(">\r\n");

            
            #line 92 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
					
            
            #line default
            #line hidden
            
            #line 92 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                     if (Model.Published.HasValue) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t<li><a");

WriteLiteral(" id=\"submit-unpublish\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Unpublish</a></li>\r\n");

            
            #line 94 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
					} else {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t<li><a");

WriteLiteral(" id=\"submit-publish\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Publish now</a></li>\r\n");

            
            #line 96 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
					}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n\t\t\t\t\t<li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3069), Tuple.Create("\"", 3121)
            
            #line 98 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3076), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", new { @id = Model.Id })
            
            #line default
            #line hidden
, 3076), false)
);

WriteLiteral(">Delete post</a></li>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 105 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.Title, new { @class = "form-control title", @placeholder = "Your post title" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 106 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");

            
            #line 110 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n\t\t\t<h3");

WriteLiteral(" class=\"panel-title\"");

WriteLiteral(">");

            
            #line 113 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                               Write(Piranha.Manager.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\t\t</div>\r\n\t\t<div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"col-sm-8\"");

WriteLiteral(">\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 119 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.TextAreaFor(m => m.Excerpt, new { @rows = 7, @class = "form-control count-me", @placeholder = "Short excerpt" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t<p><span>");

            
            #line 120 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                             Write(Model.Excerpt != null ? Model.Excerpt.Length : 0);

            
            #line default
            #line hidden
WriteLiteral("</span>/512 characters</p>\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 121 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Excerpt));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 126 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.DropDownListFor(m => m.AuthorId, Model.Authors, "", new { @class = "form-control meta", @placeholer = "Select author" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 129 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Keywords, new { @class = "form-control meta", @placeholder = "Meta keywords" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 130 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Keywords));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 133 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.TextAreaFor(m => m.Description, new { @rows = 4, @class = "form-control meta count-me", @placeholder = "Meta description" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t<p");

WriteLiteral(" class=\"charcount\"");

WriteLiteral("><span>");

            
            #line 134 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                               Write(Model.Description != null ? Model.Description.Length : 0);

            
            #line default
            #line hidden
WriteLiteral("</span>/255 characters</p>\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 135 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 142 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.HiddenFor(m => m.SelectedCategories));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");

            
            #line 148 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" role=\"tablist\"");

WriteLiteral(">\r\n\r\n\t\t\t</div>\r\n\t\t\t<div");

WriteLiteral(" class=\"btn-group pull-right\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\r\n\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-sm btn-labeled btn-info\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"btn-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<i");

WriteLiteral(" class=\"glyphicon glyphicon-paperclip\"");

WriteLiteral("></i>\r\n\t\t\t\t\t</span>\r\n\t\t\t\t\tAttachments\r\n\t\t\t\t</button>\r\n\t\t\t</div>\r\n\t\t\t<button");

WriteLiteral(" class=\"btn btn-sm btn-primary pull-right\"");

WriteLiteral(">Main body</button>\r\n\t\t\t<button");

WriteLiteral(" class=\"btn btn-sm btn-primary pull-right\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">Excerpt</button>\r\n\t\t\t<h3");

WriteLiteral(" class=\"panel-title\"");

WriteLiteral(">Content</h3>\r\n\t\t</div>\r\n\t\t<div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(" style=\"padding:0\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" style=\"border:0\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 168 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
           Write(Html.TextAreaFor(m => m.Body, new { @rows = 14, @class = "form-control editor" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");

            
            #line 172 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n\t\t</div>\r\n\t</div>\r\n");

            
            #line 177 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<!-- Comments modal -->\r\n");

WriteLiteral("\t<div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"mdComments\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n\t\t\t\t\t<h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"myModalLabel\"");

WriteLiteral(">");

            
            #line 183 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                                         Write(Piranha.Manager.Resources.Post.Comments);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div");

WriteLiteral(" id=\"comments\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 186 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
               Write(Html.Partial("Partial/CommentList", Model.Comments));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n\t\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">");

            
            #line 189 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                                                                  Write(Piranha.Manager.Resources.Global.Ok);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");

            
            #line 194 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<!-- Settings modal -->\r\n");

WriteLiteral("\t<div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"mdSettings\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n\t\t\t\t\t<h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"myModalLabel\"");

WriteLiteral(">Post settings</h4>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 203 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
               Write(Html.LabelFor(m => m.Slug, Piranha.Manager.Resources.Global.Slug));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 205 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Slug, new { @class = "form-control meta", @placeholder = "A slug will be generated automatically" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div>\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 207 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
               Write(Html.LabelFor(m => m.Route, Piranha.Manager.Resources.Global.Route));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 209 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Route, new { @class = "form-control meta", @placeholder = "Add optional route" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div>\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 211 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
               Write(Html.LabelFor(m => m.View, Piranha.Manager.Resources.Global.View));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 213 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.View, new { @class = "form-control meta", @placeholder = "Add optional view" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n\t\t\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">");

            
            #line 217 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
                                                                                  Write(Piranha.Manager.Resources.Global.Ok);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");

            
            #line 222 "..\..\Areas\Manager\Views\PostMgr\Edit.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591