using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarktVille.Models;
using MarktVille.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarktVille.Controllers
{
    public class LocationController : Controller
    {
        private List<Location> _locality;

        private ILocationRepository _locationRepository;
       
        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            _locality = _locationRepository.GetAllLocations().ToList();
            model.Locations = _locality;
            return View(model);
        }
    }
}