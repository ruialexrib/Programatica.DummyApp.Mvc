#pragma checksum "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "091e23015c02a7a8f8aac8c10240b22c9e2147db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Delete.cshtml", typeof(AspNetCore.Views_Users_Delete))]
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
#line 1 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\_ViewImports.cshtml"
using Programatica.DummyApp.Mvc;

#line default
#line hidden
#line 2 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\_ViewImports.cshtml"
using Programatica.DummyApp.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"091e23015c02a7a8f8aac8c10240b22c9e2147db", @"/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc262ee08617518f4d8949a831b221eff2799ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Programatica.DummyApp.Mvc.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
            BeginContext(86, 165, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(252, 40, false);
#line 15 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(292, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(338, 36, false);
#line 19 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(374, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(420, 41, false);
#line 23 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(461, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(507, 37, false);
#line 27 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(544, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(590, 44, false);
#line 31 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(634, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(680, 40, false);
#line 35 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(720, 32, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
            EndContext();
#line 40 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
     using (Html.BeginForm()) {
        

#line default
#line hidden
            BeginContext(794, 23, false);
#line 41 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(821, 135, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
            EndContext();
            BeginContext(957, 40, false);
#line 45 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(997, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 47 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1022, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Programatica.DummyApp.Mvc.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
