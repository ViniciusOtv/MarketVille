#pragma checksum "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac9ed5702f02e5a33146d58ca84bdc6e605b3fbe"
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
#line 1 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\_ViewImports.cshtml"
using MarktVille;

#line default
#line hidden
#line 2 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\_ViewImports.cshtml"
using MarktVille.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac9ed5702f02e5a33146d58ca84bdc6e605b3fbe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b4c6395c59857e88891e6ec1657c07bc63e84e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
  
ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(70, 3172, true);
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
                    <div class=""carousel-caption flexslider""
                        style=""color: white; font-weight: 700; font-size: 1.5rem; font-family: 'Libre Baskerville', serif"">
                        <p>Quer evitar a multidão da 25 de Março?</p>
                    </div>
                </div>
     ");
            WriteLiteral(@"           <div class=""carousel-item"">
                    <img src=""https://source.unsplash.com/HAIPJ8PyeL8/2300x900"" class=""d-block w-100"" alt=""..."">
                    <div class=""carousel-caption flexslider""
                        style=""color: white; font-weight: 700; font-size: 1.5rem; font-family: 'Libre Baskerville', serif"">
                        <h5>sem sair do conforto da sua casa.</h5>
                        <p>Compre os produtos da 25 de Março com os mesmos preços da 25 de Março</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img src=""https://source.unsplash.com/_3Q3tsJ01nc/2300x900"" class=""d-block w-100"" alt=""..."">
                    <div class=""carousel-caption flexslider""
                        style=""color: white; font-weight: 700; font-size: 1.5rem; font-family: 'Libre Baskerville', serif"">
                        <h5>Third slide label</h5>
                        <p>Faça compras nos maiores polos de ve");
            WriteLiteral(@"ndas da América Latina à preço de atacado.</p>
                    </div>
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>


        <div class=""row"">

            <div class=""container col-12 center-page"" style=""margin-top: 120px;"">
                <p style=""font-weight: 700; font:family:'Libre Baskerville', serif !important; 
            font-size: 1.75rem; color: rgba(72,72,72,0.6) !important;""> Visite as melhores Lojas nas melhores regiões.
                </p>");
            WriteLiteral("\n                <section class=\"container py-lg-4 mb-4\">\r\n                    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 59 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
                         foreach (var store in Model.Stores)
                        {

#line default
#line hidden
            BeginContext(3331, 236, true);
            WriteLiteral("                        <div class=\"col-md-3 col-sm-4 col-6\">\r\n                            <a class=\"box-shadow-sm d-block bg-white pb-sm-4 py-sm-4 \r\n                        mb-grid-gutter my-grid-gutter ml-auto mx-auto mr-auto mx-auto\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                                href=\"", 3567, "\"", 3640, 2);
            WriteAttributeValue("", 3607, "/store/storedetail/", 3607, 19, true);
#line 64 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 3626, store.StoreId, 3626, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3641, 105, true);
            WriteLiteral(" style=\"box-sizing: border-box;\">\r\n                                <img class=\"d-block mx-auto img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3746, "\"", 3764, 1);
#line 65 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 3752, store.Image, 3752, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3765, 136, true);
            WriteLiteral("\r\n                                    style=\"max-width: 150px; height: 80px;\" />\r\n                                <p class=\"name-store\">");
            EndContext();
            BeginContext(3902, 10, false);
#line 67 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
                                                 Write(store.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3912, 72, true);
            WriteLiteral("</p>\r\n                            </a>\r\n                        </div>\r\n");
            EndContext();
#line 70 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4011, 671, true);
            WriteLiteral(@"                    </div>
                </section>

            </div>
        </div>
    </div>


    <div class=""container"" style=""background-color: rgb(58,58,58); margin-top: 150px; height: auto"">

        <p style=""color: white; padding-top: 15px; text-align: center; font-family:'Libre Baskerville', serif; font-weight: 500; 
        font-size: 1.55rem;"">
            Veja alguns dos nossos produtos <bold> direto da 25 de Março</bold>
        </p>

        <div class=""row"" style=""background-color: #ededed; padding: 20px;"">
            <div class=""container"">
                <div id=""slideCard"">
                    <div class=""your-class"">
");
            EndContext();
#line 90 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
            BeginContext(4775, 203, true);
            WriteLiteral("                        <div class=\"card mb-4 bg-white rounded div-product\"\r\n                            style=\"margin-right: 20px; margin-top: 50px;\">\r\n                            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4978, "\"", 4998, 1);
#line 94 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 4984, product.Image, 4984, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4999, 186, true);
            WriteLiteral(" />\r\n                            <i class=\"far fa-heart heart-icon-card\"></i>\r\n                            <div class=\"card-body card-product-shadow\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5185, "\"", 5234, 2);
            WriteAttributeValue("", 5192, "/product/productdetails/", 5192, 24, true);
#line 97 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
WriteAttributeValue("", 5216, product.ProductId, 5216, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5235, 112, true);
            WriteLiteral(" style=\"text-decoration: none; \">\r\n                                    <p class=\"card-title product-card-title\">");
            EndContext();
            BeginContext(5348, 12, false);
#line 98 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
                                                                        Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5360, 83, true);
            WriteLiteral("</p>\r\n                                    <p class=\"card-text product-card-text\">R$");
            EndContext();
            BeginContext(5444, 20, false);
#line 99 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
                                                                        Write(product.SellingPrice);

#line default
#line hidden
            EndContext();
            BeginContext(5464, 89, true);
            WriteLiteral("</p>\r\n                                    <p class=\"card-subtitle product-card-subtitle\">");
            EndContext();
            BeginContext(5554, 24, false);
#line 100 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
                                                                              Write(product.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(5578, 616, true);
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
#line 114 "C:\Users\vinicius.silva\source\repos\MarketVille\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(6221, 682, true);
            WriteLiteral(@"                    </div>
                </div>

            </div>
            <div class=""container"" style=""text-align: center;"">
                <a href=""#slideCard"" data-slide=""prev"">
                    <span type=""button"" class=""btn-square"" style=""text-align: center""><i
                            class=""fas fa-chevron-left""></i></span>
                </a>
                <a href=""#slideCard"" data-slide=""next"">
                    <span type=""button"" class=""btn-square"" style=""text-align: center""><i
                            class=""fas fa-chevron-right""></i></span>
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
