#pragma checksum "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef1982be22cd60575c4c854c58da1ac7aba5c26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef1982be22cd60575c4c854c58da1ac7aba5c26", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b4c6395c59857e88891e6ec1657c07bc63e84e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 2704, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""bd-example"" style=""margin-top: 30px;"">
        <div id=""carouselExampleCaptions"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#carouselExampleCaptions"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleCaptions"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleCaptions"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img src=""https://source.unsplash.com/D6Bk1A3-gMA/2300x900"" class=""d-block w-100"" alt=""..."">
                    <div class=""carousel-caption flexslider"" style=""color: white; font-weight: 700; font-size: 1.5rem;"">
                        <p>Quer evitar a multidão da 25 de Março?</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img ");
            WriteLiteral(@"src=""https://source.unsplash.com/HAIPJ8PyeL8/2300x900"" class=""d-block w-100"" alt=""..."">
                    <div class=""carousel-caption flexslider"" style=""color: white; font-weight: 700; font-size: 1.5rem;"">
                        <h5>sem sair do conforto da sua casa.</h5>
                        <p>Compre os produtos da 25 de Março com os mesmos preços da 25 de Março</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img src=""https://source.unsplash.com/_3Q3tsJ01nc/2300x900"" class=""d-block w-100"" alt=""..."">
                    <div class=""carousel-caption flexslider"" style=""color: white; font-weight: 700; font-size: 1.5rem;"">
                        <h5>Third slide label</h5>
                        <p>Faça compras nos maiores polos de vendas da América Latina à preço de atacado.</p>
                    </div>
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleCaptions");
            WriteLiteral(@""" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>

        <div class=""container col-12 center-page"" style=""margin-top: 120px"">
            <p> Visite as melhores Lojas nas melhores regiões.</p>

            <div class=""row"">
");
            EndContext();
#line 50 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                 foreach (var store in Model.Stores)
                {


#line default
#line hidden
            BeginContext(2853, 147, true);
            WriteLiteral("                    <div class=\"card mb-4\" style=\"margin-left: 30px; box-shadow: 0 1px 15px rgba(128, 128, 128, 0.3);\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3000, "\"", 3040, 2);
            WriteAttributeValue("", 3007, "/store/storedetail/", 3007, 19, true);
#line 54 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 3026, store.StoreId, 3026, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3041, 53, true);
            WriteLiteral(">\r\n                            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3094, "\"", 3112, 1);
#line 55 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 3100, store.Image, 3100, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3113, 55, true);
            WriteLiteral(" />\r\n                            <p class=\"name-store\">");
            EndContext();
            BeginContext(3169, 10, false);
#line 56 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                                             Write(store.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3179, 64, true);
            WriteLiteral("</p>\r\n                        </a>\r\n                    </div>\r\n");
            EndContext();
#line 59 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3262, 522, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>


    <div class=""container"" style=""background-color: rgb(58,58,58); margin-top: 150px; height: auto"">

        <p style=""color: white; padding: 10px; text-align: center"">
            Veja alguns dos nossos produtos <bold> direto da 25 de Março</bold>
        </p>

        <div class=""row"" style=""background-color: #ededed; padding: 20px;"">
            <div class=""container"">
                <div id=""slideCard"">
                    <div class=""your-class"">
");
            EndContext();
#line 76 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
            BeginContext(3877, 182, true);
            WriteLiteral("                            <div class=\"card mb-4 bg-white rounded div-product\" style=\"margin-right: 20px; margin-top: 50px;\">\r\n                                <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4059, "\"", 4079, 1);
#line 79 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 4065, product.Image, 4065, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4080, 198, true);
            WriteLiteral(" />\r\n                                <i class=\"far fa-heart heart-icon-card\"></i>\r\n                                <div class=\"card-body card-product-shadow\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4278, "\"", 4327, 2);
            WriteAttributeValue("", 4285, "/product/productdetails/", 4285, 24, true);
#line 82 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 4309, product.ProductId, 4309, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4328, 116, true);
            WriteLiteral(" style=\"text-decoration: none; \">\r\n                                        <p class=\"card-title product-card-title\">");
            EndContext();
            BeginContext(4445, 12, false);
#line 83 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                                                                            Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4457, 87, true);
            WriteLiteral("</p>\r\n                                        <p class=\"card-text product-card-text\">R$");
            EndContext();
            BeginContext(4545, 20, false);
#line 84 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                                                                            Write(product.SellingPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4565, 93, true);
            WriteLiteral("</p>\r\n                                        <p class=\"card-subtitle product-card-subtitle\">");
            EndContext();
            BeginContext(4659, 24, false);
#line 85 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                                                                                  Write(product.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(4683, 660, true);
            WriteLiteral(@"</p>

                                        <hr style=""background-color: black"">

                                    </a>
                                    <div class=""row icon-card"">
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                    </div>
                                </div>
                            </div>
");
            EndContext();
#line 99 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5370, 624, true);
            WriteLiteral(@"                    </div>
                </div>

            </div>
            <div class=""container"" style=""text-align: center;"">
                <a href=""#slideCard"" data-slide=""prev"">
                    <span type=""button"" class=""btn-square"" style=""text-align: center""><i class=""fas fa-chevron-left""></i></span>
                </a>
                <a href=""#slideCard"" data-slide=""next"">
                    <span type=""button"" class=""btn-square"" style=""text-align: center""><i class=""fas fa-chevron-right""></i></span>
                </a>
            </div>
        </div>


    </div>




</div>");
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
