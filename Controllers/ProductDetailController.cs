using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarktVille.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarktVille.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index()
        {
            var model = new ProductDetailIndexModel();
            
            return View();
        }
    }
}