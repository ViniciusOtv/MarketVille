using MarktVille.Models;
using MarktVille.Repository;
using MarktVille.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISubCategoryRepository _subcategoryRepository;
        private readonly ILogger<ProductController> _logger;

        public ProductController(
            IProductService productService,
            ICategoryRepository categoryRepository,
            ISubCategoryRepository subCategoryRepository,
            ILogger<ProductController> logger)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _subcategoryRepository = subCategoryRepository ?? throw new ArgumentNullException(nameof(subCategoryRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Attempting to retrieve products for Index page.");
            try
            {
                var model = new HomeIndexViewModel();
                
                // Fetch products using the new service layer
                model.Products = _productService.GetAllProducts().ToList();
                
                // Keep category and subcategory logic as is for now, as the scope is limited to Product module refactoring
                var categories = _categoryRepository.GetAllCategories().ToList();
                var subcategories = new List<SubCategory>();

                foreach (var item in categories)
                {
                    subcategories.AddRange(_subcategoryRepository.GetSubCategorieByCategoryId(item.CategoryId).ToList());
                }
            
                model.Categories = categories;
                model.SubCategories = subcategories;

                _logger.LogInformation("Successfully retrieved products and categories for Index page.");
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving products for Index page.");
                return StatusCode(500, "Internal server error"); // Generic error response
            }
        }

        public IActionResult ProductDetails(int id)
        {
            _logger.LogInformation("Attempting to retrieve details for product with ID: {ProductId}", id);
            try
            {
                var model = new HomeIndexViewModel(); // Re-using HomeIndexViewModel as per existing code structure
                
                // Fetch product details using the new service layer
                model.Products = _productService.GetProductById(id).ToList();

                if (!model.Products.Any())
                {
                    _logger.LogWarning("Product with ID: {ProductId} not found.", id);
                    return NotFound($"Product with ID {id} not found.");
                }

                _logger.LogInformation("Successfully retrieved details for product with ID: {ProductId}.", id);
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving details for product with ID: {ProductId}.", id);
                return StatusCode(500, "Internal server error"); // Generic error response
            }
        }
    }
}