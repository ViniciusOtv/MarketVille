using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarktVille.Models;
using MarktVille.DAL;
using MarktVille.Repository;

namespace MarktVille.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> _products;
        private List<Store> _stores;

        private IProductRepository _productRepository;
        private IStoreRepository _storeRepository;


        public HomeController(IProductRepository productRepository, IStoreRepository storeRepository)
        {
            _productRepository = productRepository;
            _storeRepository = storeRepository;

        }
        public IActionResult Index()
        {
            _products = _productRepository.GetAllProducts().ToList();
            _stores = _storeRepository.GetTopStore().ToList();
            var model = new HomeIndexViewModel();
            model.Products = _products;
            model.Stores = _stores;
            return View(model);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
