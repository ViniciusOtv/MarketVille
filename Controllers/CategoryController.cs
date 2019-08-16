using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarktVille.Models;
using MarktVille.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarktVille.Controllers
{
    public class CategoryController : Controller
    {
        private List<Category> _categories;

        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            _categories = _categoryRepository.GetAllCategories().ToList();
            model.Categories = _categories;

            return View(model);
        }
    }
}