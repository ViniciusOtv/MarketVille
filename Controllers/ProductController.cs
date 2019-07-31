using MarktVille.Models;
using MarktVille.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _product;

        private IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
     

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            _product = _productRepository.GetAllProducts().ToList();
            model.Products = _product;

            return View(model);
        }

        public IActionResult ProductDetails(int id)
        {
            var model = new HomeIndexViewModel();
            _product = _productRepository.GetProductById(id).ToList();
            model.Products = _product;

            return View(model);
        }
    }
}