using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarktVille.DAL;
using MarktVille.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly DatabaseDb _context;

        public ProductController(DatabaseDb context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Products = _context.Products.OrderByDescending(x => x.ProductId).ToList();
            return View(model);
        }
    }
}