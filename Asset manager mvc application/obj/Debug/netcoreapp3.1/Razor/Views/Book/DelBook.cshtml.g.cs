#pragma checksum "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\Book\DelBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cea40fe8509bc542b0dae6115952da0658a6127"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_DelBook), @"mvc.1.0.view", @"/Views/Book/DelBook.cshtml")]
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
#line 1 "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\_ViewImports.cshtml"
using AssetManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\_ViewImports.cshtml"
using AssetManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cea40fe8509bc542b0dae6115952da0658a6127", @"/Views/Book/DelBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c79aa51e37bc5b40d71c2b54724aa3912b6a1ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_DelBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssetManagement.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\Book\DelBook.cshtml"
    using (Html.BeginForm())
  {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\Book\DelBook.cshtml"
 Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("      <fieldset>\r\n          <div class=\"editor-label\">\r\n              ");
#nullable restore
#line 8 "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\Book\DelBook.cshtml"
         Write(Html.LabelFor(model=>model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </div>\r\n          <div class=\"editor-label\">\r\n              ");
#nullable restore
#line 11 "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\Book\DelBook.cshtml"
         Write(Html.EditorFor(model=>model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              ");
#nullable restore
#line 12 "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\Book\DelBook.cshtml"
         Write(Html.ValidationMessageFor(model=>model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </div>\r\n          <input type =\"submit\" class= \"btn btn-primary\" value =\"Delete\"/>\r\n      </fieldset>\r\n");
#nullable restore
#line 16 "C:\Users\apoorva.sapra\Desktop\week 5\AssetManagement\Views\Book\DelBook.cshtml"
  }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssetManagement.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
