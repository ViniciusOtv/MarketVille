#pragma checksum "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8c4bee3360bc5e828122565b78785ad685d249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/Index.cshtml", typeof(AspNetCore.Views_Store_Index))]
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
#line 1 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\_ViewImports.cshtml"
using MarktVille;

#line default
#line hidden
#line 2 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\_ViewImports.cshtml"
using MarktVille.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8c4bee3360bc5e828122565b78785ad685d249", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b4c6395c59857e88891e6ec1657c07bc63e84e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Store\Index.cshtml"
  
ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(64, 173, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\" style=\"margin: 30px 30px;\">\r\n                <div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Store\Index.cshtml"
                     foreach (var store in Model.Stores)
                    {

#line default
#line hidden
            BeginContext(318, 166, true);
            WriteLiteral("                    <div class=\"card mb-4 div-product-store \" style=\"margin-left: 20px; box-shadow: 0 1px 15px rgba(128, 128, 128, 0.3);\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 484, "\"", 524, 2);
            WriteAttributeValue("", 491, "/store/storedetail/", 491, 19, true);
#line 14 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Store\Index.cshtml"
WriteAttributeValue("", 510, store.StoreId, 510, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(525, 53, true);
            WriteLiteral(">\r\n                            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 578, "\"", 596, 1);
#line 15 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Store\Index.cshtml"
WriteAttributeValue("", 584, store.Image, 584, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(597, 63, true);
            WriteLiteral(" />\r\n                        </a>\r\n                    </div>\r\n");
            EndContext();
#line 18 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Store\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(683, 84, true);
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
