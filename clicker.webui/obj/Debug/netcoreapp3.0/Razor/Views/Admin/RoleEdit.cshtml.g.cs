#pragma checksum "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d96a0980180418b99a184cdab8ccda654105e3ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleEdit), @"mvc.1.0.view", @"/Views/Admin/RoleEdit.cshtml")]
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
#nullable restore
#line 2 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using clicker.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using clicker.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using clicker.webui.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using clicker.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96a0980180418b99a184cdab8ccda654105e3ba", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e1c69efd376f1830288135e579caa4485717bc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
  
   Layout="~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-dark\">Role Edit</h2>\r\n<hr>\r\n\r\n<div  class=\"row \">\r\n    <div class=\"col-md-12\">\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96a0980180418b99a184cdab8ccda654105e3ba4703", async() => {
                WriteLiteral("\r\n      <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 272, "\"", 294, 1);
#nullable restore
#line 12 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 280, Model.Role.Id, 280, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 342, "\"", 366, 1);
#nullable restore
#line 13 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 350, Model.Role.Name, 350, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n         <h6 class=\"bg-info text-dark p-1\">Add To ");
#nullable restore
#line 14 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
                                             Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n         <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 16 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
              if (Model.NonMembers.Count()==0)
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <tr>\r\n                     <td colspan=\"2\">\r\n                      Butun Istifadeciler Rola Aiddir\r\n                     </td>\r\n                 </tr>\r\n");
#nullable restore
#line 23 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
                 
             }

             else  {
                  foreach (var user in Model.NonMembers)
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                      <tr>\r\n                          <td>");
#nullable restore
#line 30 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
                         Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                          <td style=\"width: 150px;\">\r\n                              <input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 1071, "\"", 1087, 1);
#nullable restore
#line 32 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1079, user.Id, 1079, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                               \r\n                          </td>\r\n                      </tr>\r\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
                      
                  }

             }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n         </table>\r\n\r\n         <hr>\r\n         \r\n         <h6 class=\"bg-info text-dark p-1\">Remove From ");
#nullable restore
#line 45 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
                                                  Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n         <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
              if (Model.Members.Count()==0)
             {


#line default
#line hidden
#nullable disable
                WriteLiteral("                 <tr>\r\n                     <td colspan=\"2\">Rola aid istifadeci Yoxdur</td>\r\n                 </tr>\r\n");
#nullable restore
#line 53 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"

                 

                 
             }

             else
             {
                 foreach (var user in Model.Members)
                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                     <tr>\r\n                     <td>");
#nullable restore
#line 64 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
                    Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                     <td style=\"width: 150px;\">\r\n                      <input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 1966, "\"", 1982, 1);
#nullable restore
#line 66 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1974, user.Id, 1974, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                     </td>\r\n                     \r\n                     </tr>\r\n");
#nullable restore
#line 71 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Admin\RoleEdit.cshtml"
                  
                 }
                 
             }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n         </table>\r\n\r\n         <button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\r\n\r\n     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
