#pragma checksum "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1218f516efd644fa7a9570c7c289c8e8c05938c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Create), @"mvc.1.0.view", @"/Views/Users/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Create.cshtml", typeof(AspNetCore.Views_Users_Create))]
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
#line 1 "W:\Github\Programatica.DummyApp.Mvc\Views\_ViewImports.cshtml"
using Programatica.DummyApp.Mvc;

#line default
#line hidden
#line 2 "W:\Github\Programatica.DummyApp.Mvc\Views\_ViewImports.cshtml"
using Programatica.DummyApp.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1218f516efd644fa7a9570c7c289c8e8c05938c9", @"/Views/Users/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc262ee08617518f4d8949a831b221eff2799ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Programatica.DummyApp.Data.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(87, 23, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
            BeginContext(146, 23, false);
#line 12 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(177, 82, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>User</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(260, 64, false);
#line 17 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(324, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(373, 93, false);
#line 19 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(466, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(522, 93, false);
#line 21 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(615, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(634, 82, false);
#line 22 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(716, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(803, 94, false);
#line 27 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(897, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(953, 94, false);
#line 29 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1066, 83, false);
#line 30 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1236, 97, false);
#line 35 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
       Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1389, 97, false);
#line 37 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
           Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1505, 86, false);
#line 38 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 48 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
}

#line default
#line hidden
            BeginContext(1849, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1863, 40, false);
#line 51 "W:\Github\Programatica.DummyApp.Mvc\Views\Users\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Programatica.DummyApp.Data.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
