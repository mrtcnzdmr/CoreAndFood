#pragma checksum "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803bc627fffd018acd9270b5e34731be85e7ecb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803bc627fffd018acd9270b5e34731be85e7ecb4", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Category List</h2>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Food Name:");
#nullable restore
#line 12 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
             Write(Html.TextBox("p"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Find\" />\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Category Name</th>\r\n        <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 682, "\"", 730, 2);
            WriteAttributeValue("", 689, "/Category/CategoryRemove/", 689, 25, true);
#nullable restore
#line 31 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 714, item.CategoryId, 714, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 790, "\"", 835, 2);
            WriteAttributeValue("", 797, "/Category/CategoryGet/", 797, 22, true);
#nullable restore
#line 32 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 819, item.CategoryId, 819, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\dooms\OneDrive\Masaüstü\MuratYücedağ MVC CORE PROJECT FOOD\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Category/CategoryAdd/\" class=\"btn btn-primary\">New Category</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
