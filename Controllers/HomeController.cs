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
        private List<Product> _prdCarousel;
        private List<Store> _stores;

        private List<Location> _locality;
        private IProductRepository _productRepository;
        private IStoreRepository _storeRepository;

        private ILocationRepository _locationRepository;


        public HomeController(IProductRepository productRepository, IStoreRepository storeRepository, 
        ILocationRepository locationRepository)
        {
            _productRepository = productRepository;
            _storeRepository = storeRepository;
            _locationRepository = locationRepository;

        }
        public IActionResult Index()
        {
            //_products = _productRepository.GetAllProducts().ToList();
            _stores = _storeRepository.GetTopStore().ToList();
            _prdCarousel = _productRepository.GetProductForCarousel().ToList();
            _locality = _locationRepository.GetAllLocations().ToList();
            var model = new HomeIndexViewModel();
            model.Products = _prdCarousel;
            model.Stores = _stores;
            model.Locations = _locality;
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
