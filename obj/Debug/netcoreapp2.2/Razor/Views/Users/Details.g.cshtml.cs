#pragma checksum "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "399d5223da436c4ce24800cdc571c6f641063bac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Details.cshtml", typeof(AspNetCore.Views_Users_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399d5223da436c4ce24800cdc571c6f641063bac", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc262ee08617518f4d8949a831b221eff2799ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Programatica.DummyApp.Mvc.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(87, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(206, 40, false);
#line 14 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(246, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 36, false);
#line 18 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(328, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(374, 41, false);
#line 22 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(415, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(461, 37, false);
#line 26 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(498, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(544, 44, false);
#line 30 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(588, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(634, 40, false);
#line 34 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(674, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(722, 54, false);
#line 40 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(776, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(785, 40, false);
#line 41 "C:\Users\ruiribeiro\Documents\GitHub\Programatica.DummyApp.Mvc\Views\Users\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(825, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
