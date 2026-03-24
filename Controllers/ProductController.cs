using MarktVille.Models;
using MarktVille.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger _logger;

        public ProductController(IProductService productService, ILogger logger)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _logger = logger.ForContext<ProductController>() ?? throw new ArgumentNullException(nameof(logger));
        }

        public IActionResult Index()
        {
            _logger.Information("Request received for Product Index page.");
            try
            {
                var model = _productService.GetHomeIndexViewModelData();
                _logger.Information("Successfully retrieved data for Product Index page.");
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while retrieving data for Product Index page.");
                return StatusCode(500, "An error occurred while loading the product index.");
            }
        }

        public IActionResult ProductDetails(int id)
        {
            _logger.Information("Request received to get product details for ID: {ProductId}", id);
            try
            {
                var product = _productService.GetProductDetails(id);
                if (product == null)
                {
                    _logger.Warning("Product with ID: {ProductId} not found.", id);
                    return NotFound();
                }

                // The original controller returned a HomeIndexViewModel with a list containing the product.
                // We maintain this structure for view compatibility.
                var model = new HomeIndexViewModel
                {
                    Products = new List<Product> { product }
                };

                _logger.Information("Successfully retrieved product details for ID: {ProductId}", id);
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while retrieving product details for ID: {ProductId}.", id);
                return StatusCode(500, "An error occurred while retrieving product details.");
            }
        }
    }
}