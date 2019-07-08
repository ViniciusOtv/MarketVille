using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarktVille.DAL;
using MarktVille.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarktVille.Controllers
{
    public class StoreController : Controller
    {
        private readonly DatabaseDb _context;
        public StoreController(DatabaseDb context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var model = new HomeIndexViewModel();
            model.SelectStore = id;
            model.Products = _context.Products.ToArray();
            model.Stores = _context.Stores.ToArray();


            model.Stores = model.Stores
                .Where(x => x.StoreId == id)
                .ToArray();

            model.Products = model.Products
                .Where(p => p.StoreId == id)
                .ToArray();

            return View(model);
        }
    }
}