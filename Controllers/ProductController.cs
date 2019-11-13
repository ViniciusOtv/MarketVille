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
        private List<Category> _categories;
        private List<SubCategory> _subcategory;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private ISubCategoryRepository _subcategoryRepository;
        
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, ISubCategoryRepository subCategoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _subcategoryRepository =  subCategoryRepository;
        }
     

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            _product = _productRepository.GetAllProducts().ToList();
            _categories = _categoryRepository.GetAllCategories().ToList();
            //_subcategory = _subcategoryRepository.GetSubCategorieByCategoryId(_categories).ToList();
           
            model.Products = _product;
            model.Categories = _categories;

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