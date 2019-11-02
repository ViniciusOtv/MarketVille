using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MarktVille.DAL;
using MarktVille.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MarktVille.Repository;

namespace MarktVille.Controllers
{
    public class StoreController : Controller
    {
        private List<Store> _stores;
        private List<Store> _prdStore;
        private List<Product> _selectProductStore;
        private List<Store> _storeLocator;
        private List<Location> _locality;
        private IStoreRepository _storeRepository;
        private IProductRepository _productRepository;
        private ILocationRepository _locationRepository;


        public StoreController(IStoreRepository storeRepository, IProductRepository productRepository, 
                                ILocationRepository locationRepository)
        {
            _storeRepository = storeRepository;
            _productRepository = productRepository;
            _locationRepository = locationRepository;
        }



        public IActionResult Index()
        {
            try
            {
                var model = new HomeIndexViewModel();
                _stores = _storeRepository.GetAllStores().ToList();
                model.Stores = _stores;

                if (_stores.Count() == 0)
                {
                    return View(ViewBag.Message = "Não há lojas para serem exibidas");
                }

                return View(model);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult StoreDetail(int id)
        {
            try
            {
                _prdStore = _storeRepository.GetStoreById(id).ToList();
                _selectProductStore = _productRepository.GetProductStore(id).ToList();
                var model = new HomeIndexViewModel();
                model.Stores = _prdStore;
                model.Products = _selectProductStore;

                if (_prdStore.Count() == 0)
                {

                    return View(ViewBag.Message = "Não há lojas para serem exibidas");
                }

                return View(model);
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IActionResult StoreLocation(int id)
        {
            try
            {
                _storeLocator = _storeRepository.GetStoreByLocationId(id).ToList();
                _locality = _locationRepository.GetLocalityById(id).ToList();

                var model = new HomeIndexViewModel();
                model.Stores = _storeLocator;
                model.Locations = _locality;

                return View(model);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}