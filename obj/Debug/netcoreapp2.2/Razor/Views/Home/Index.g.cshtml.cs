#pragma checksum "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2154131df7141c140bc5d924d772d1301caed1ee"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2154131df7141c140bc5d924d772d1301caed1ee", @"/Views/Home/Index.cshtml")]
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
            BeginWriteAttribute("href", " href=\"", 3000, "\"", 3034, 2);
            WriteAttributeValue("", 3007, "/store/index/", 3007, 13, true);
#line 54 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 3020, store.StoreId, 3020, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3035, 53, true);
            WriteLiteral(">\r\n                            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3088, "\"", 3106, 1);
#line 55 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 3094, store.Image, 3094, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3107, 63, true);
            WriteLiteral(" />\r\n                        </a>\r\n                    </div>\r\n");
            EndContext();
#line 58 "C:\Users\vinicius.silva\source\repos\Vandora_MarktVille\MarktVille\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4227, 4486, true);
            WriteLiteral(@"

            </div>
        </div>
    </div>


    <div class=""container-fluid"" style=""background-color: rgb(58,58,58); margin-top: 150px; height: auto"">

        <p style=""color: white; padding: 10px; text-align: center"">
            Veja alguns dos nossos produtos <bold> direto da 25 de Março</bold>
        </p>

        <div class=""row"" style=""background-color: #ededed; padding: 20px;"">
            <div class=""container-fluid"">

                <div id=""slideCard"" class=""carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner  w-100 mx-auto"">
                        <div class=""carousel-item col-md-4 active"">
                            <div class=""card"" style=""box-shadow: 0 5px 15px rgba(58, 58, 58, 0.5); margin-left: 20px"">
                                <img class=""img-fluid"" src=""https://source.unsplash.com/c2x94-kmQcQ/230x255"" />
                                <div class=""card-body card-product-shadow"">
                                    <p class");
            WriteLiteral(@"=""card-text"">
                                        Tênis Nike
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""carousel-item col-md-4"">
                            <div class=""card"" style=""box-shadow: 0 5px 15px rgba(58, 58, 58, 0.5); margin-left: 20px"">
                                <img class=""img-fluid"" src=""https://source.unsplash.com/c2x94-kmQcQ/230x255"" />
                                <div class=""card-body card-product-shadow"">
                                    <p class=""card-text"">
                                        Tênis Nike
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""carousel-item col-md-4"">
                            <div class=""card"" style=""box-shadow: 0 5px 15px rgba(58, 58, 58, 0.5); margin-left: ");
            WriteLiteral(@"20px"">
                                <img class=""img-fluid"" src=""https://source.unsplash.com/c2x94-kmQcQ/230x255"" />
                                <div class=""card-body card-product-shadow"">
                                    <p class=""card-text"">
                                        Tênis Nike
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""carousel-item col-md-4"">
                            <div class=""card"" style=""box-shadow: 0 5px 15px rgba(58, 58, 58, 0.5); margin-left: 20px"">
                                <img class=""img-fluid"" src=""https://source.unsplash.com/c2x94-kmQcQ/230x255"" />
                                <div class=""card-body card-product-shadow"">
                                    <p class=""card-text"">
                                        Tênis Nike
                                    </p>
                                </div>
");
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""carousel-item col-md-4"">

                            <div class=""card"" style=""box-shadow: 0 5px 15px rgba(58, 58, 58, 0.5); margin-left: 20px"">
                                <img class=""img-fluid"" src=""https://source.unsplash.com/c2x94-kmQcQ/230x255"" />
                                <div class=""card-body card-product-shadow"">
                                    <p class=""card-text"">
                                        Tênis Nike
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class=""container"" style=""text-align: center; margin-top: 20px; background-color: red"">
                        <a class=""carousel-control-prev"" href=""#slideCard"" data-slide=""prev"">
                            <span type=""button"" class=""btn-square"" style=""text-al");
            WriteLiteral(@"ign: center""><</span>
                        </a>
                        <a class=""carousel-control-next"" href=""#slideCard"" data-slide=""next"">
                            <span type=""button"" class=""btn-square"" style=""text-align: center"">></span>
                        </a>
                    </div>
                </div>
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
