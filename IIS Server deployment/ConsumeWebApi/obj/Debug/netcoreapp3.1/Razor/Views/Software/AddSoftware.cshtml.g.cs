#pragma checksum "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040d0fa5318a81d5805aec0546bc60910f15b117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Software_AddSoftware), @"mvc.1.0.view", @"/Views/Software/AddSoftware.cshtml")]
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
#line 1 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\_ViewImports.cshtml"
using AssetManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\_ViewImports.cshtml"
using ConsumeWebApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040d0fa5318a81d5805aec0546bc60910f15b117", @"/Views/Software/AddSoftware.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3059a143644eeabd38df49749d09d8068b5ac2b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Software_AddSoftware : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsumeWebApi.Models.Software>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
  
    ViewBag.Title = "Add New Software";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Add new Software</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n            ");
#nullable restore
#line 16 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
       Write(Html.LabelFor(model => model.name, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
           Write(Html.EditorFor(model => model.name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
           Write(Html.ValidationMessageFor(model => model.name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
       Write(Html.LabelFor(model => model.provider,  new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 29 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
           Write(Html.EditorFor(model => model.provider, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
           Write(Html.ValidationMessageFor(model => model.provider, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 35 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
       Write(Html.LabelFor(model => model.version, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
           Write(Html.EditorFor(model => model.version, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
           Write(Html.ValidationMessageFor(model => model.version, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 43 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
       Write(Html.LabelFor(model => model.price, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 45 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
           Write(Html.EditorFor(model => model.price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
           Write(Html.ValidationMessageFor(model => model.price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Add\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 56 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 59 "C:\Users\apoorva.sapra\Desktop\week 10\week10\ConsumeWebApi\Views\Software\AddSoftware.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsumeWebApi.Models.Software> Html { get; private set; }
    }
}
#pragma warning restore 1591