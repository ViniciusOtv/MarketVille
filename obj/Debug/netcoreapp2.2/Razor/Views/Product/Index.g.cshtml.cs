#pragma checksum "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2c3ea96fafb6dead13665eae464ef283e47bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\_ViewImports.cshtml"
using MarktVille;

#line default
#line hidden
#line 2 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\_ViewImports.cshtml"
using MarktVille.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2c3ea96fafb6dead13665eae464ef283e47bca", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b4c6395c59857e88891e6ec1657c07bc63e84e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(68, 307, true);
            WriteLiteral(@"

<div class=""container-fluid"">

    <div class=""row"">
        <div class=""col-3"" style=""background-color: blue; max-height: 500px; margin-top: 50px"">
            <p>categorias</p>
        </div>

        <div class=""col-9"">
            <div class=""container"">
                <div class=""row"">
");
            EndContext();
#line 17 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Product\Index.cshtml"
                     foreach (var product in Model.Products)
                    {

#line default
#line hidden
            BeginContext(460, 172, true);
            WriteLiteral("                        <div class=\"card mb-4 bg-white rounded div-product\" style=\"margin-left: 30px; margin-top: 50px\">\r\n                            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 632, "\"", 652, 1);
#line 20 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Product\Index.cshtml"
WriteAttributeValue("", 638, product.Image, 638, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(653, 169, true);
            WriteLiteral(" />\r\n                            <div class=\"card-body card-product-shadow\">\r\n                                <p class=\"card-text\">\r\n                                    ");
            EndContext();
            BeginContext(823, 12, false);
#line 23 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Product\Index.cshtml"
                               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(835, 108, true);
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 27 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(966, 82, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
