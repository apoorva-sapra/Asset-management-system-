#pragma checksum "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c3d2f2e1e01cd81c6bb5babe42e884e1197266c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hardware_Index), @"mvc.1.0.view", @"/Views/Hardware/Index.cshtml")]
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
#line 1 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\_ViewImports.cshtml"
using AssetManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\_ViewImports.cshtml"
using ConsumeWebApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3d2f2e1e01cd81c6bb5babe42e884e1197266c", @"/Views/Hardware/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3059a143644eeabd38df49749d09d8068b5ac2b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Hardware_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConsumeWebApi.Models.Hardware>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
  
    ViewData["Title"]="Hardwares";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>List of all Hardware</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th> ");
#nullable restore
#line 11 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
            Write(Html.DisplayNameFor(Model=>Model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th> ");
#nullable restore
#line 12 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
            Write(Html.DisplayNameFor(Model=>Model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th> ");
#nullable restore
#line 13 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
            Write(Html.DisplayNameFor(Model=>Model.brand));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th> ");
#nullable restore
#line 14 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
            Write(Html.DisplayNameFor(Model=>Model.model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th> ");
#nullable restore
#line 15 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
            Write(Html.DisplayNameFor(Model=>Model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
               Write(Html.DisplayFor(ModelItem=>item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
               Write(Html.DisplayFor(ModelItem=>item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
               Write(Html.DisplayFor(ModelItem=>item.brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
               Write(Html.DisplayFor(ModelItem=>item.model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
               Write(Html.DisplayFor(ModelItem=>item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          \r\n            <td>\r\n            ");
#nullable restore
#line 29 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
       Write(Html.ActionLink("Update", "UpdateHardware", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            \r\n            ");
#nullable restore
#line 31 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id = item.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n            ");
#nullable restore
#line 33 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
       Write(Html.ActionLink("Request", "CreateRequest","User", new { id = item.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n            ");
#nullable restore
#line 38 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\apoorva.sapra\Desktop\week8 - Copy\ConsumeWebApi\Views\Hardware\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tfoot></tfoot>\r\n    </tbody>\r\n</table> \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConsumeWebApi.Models.Hardware>> Html { get; private set; }
    }
}
#pragma warning restore 1591
