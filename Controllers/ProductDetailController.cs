using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarktVille.DAL;
using MarktVille.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarktVille.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly DatabaseDb _context;

        public ProductDetailController(DatabaseDb context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var model = new HomeIndexViewModel();

            model.ProductDetails = id;
            model.Products = _context.Products.ToArray();

            if (model.ProductDetails == 0)
            {
                ViewBag.message = "Não há produtos";
                
            }

            model.Products = model.Products
                .Where(x => x.ProductId == model.ProductDetails)
                .ToArray();

            return View(model);
        }
    }
}