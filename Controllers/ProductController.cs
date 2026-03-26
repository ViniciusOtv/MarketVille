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
        privateusing MarktVille.Models;
using MarktVille.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILoggerusing Microsoft.AspNetCore.Mvc;
using MarktVille.Models;
using MarktVille.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;using MarktVille.Models;
using MarktVille.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Linq;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger _logger;using MarktVille.Models;
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
        private readonly IProductService _productService;using MarktVille.Models;
using MarktVille.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="productService">The product service for business logic operations.</param>
        /// <param name="logger">The logger instance for structured logging.</param>
        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Displays the home index view with a collection of products, categories, and subcategories.
        /// </summary>
        /// <returns>An <see cref="IActionResult"/> representing the home index view.</returns>
        public IActionResult Index()
        {
            _logger.LogInformation("Attempting to retrieve data for the Product Index view.");

            try
            {
                var model = _productService.GetHomeIndexViewModel();
                _logger.LogInformation("Successfully retrieved data for Product Index view.");
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving data for Product Index view.");
                // Return a generic error view or status code
                return StatusCode(500, "An unexpected error occurred while loading products.");
            }
        }

        /// <summary>
        /// Displays the details for a specific product.
        /// </summary>
        /// <param name="id">The unique identifier of the product to display.</param>
        /// <returns>An <see cref="IActionResult"/> representing the product detailsusing MarktVille.Models;
using MarktVille.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="productService">The product service for business logic operations.</param>
        /// <param name="logger">The logger instance for structured logging.</param>
        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Displays the home index view with a list of products, categories, and subcategories.
        /// </summary>
        /// <returns>An <see cref="IActionResult"/> representing the home index view.</returns>
        public IActionResult Index()
        {
            _logger.LogInformation("Attempting to retrieve data for Home Index View.");
            try
            {
                var model = _productService.GetHomeIndexViewModel();

                if (model == null)
                {
                    _logger.LogWarning("HomeIndexViewModel returned null from ProductService.");
                    return NotFound("Could not retrieve home page data.");
                }

                _logger.LogInformation("Successfully retrieved data for Home Index View. Products:using MarktVille.Models;
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
        private readonly ILogger<ProductController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="productService">The product service for business logic operations.</param>
        /// <param name="logger">The logger instance for structured logging.</param>
        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Displays the home index view with a list of products, categories, and subcategories.
        /// </summary>
        /// <returns>An <see cref="IActionResult"/> representing the home index view.</returns>
        public IActionResult Index()
        {
            _logger.LogInformation("Attempting to retrieve data for the product index page.");

            try
            {
                var model = _productService.GetHomeIndexViewModel();
                _logger.LogInformation("Successfully retrieved data for product index page.");
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving data for product index page.");
                // Return a generic error view or a specific HTTP status code for API endpoints
                return StatusCode(500, "An error occurred while loading the product index page.");
            }
        }

        /// <summary>
        /// Displays the details for a specific product.
        /// </summary>
        /// <param name="id">The unique identifier of the product to display.</param>
        /// <returns>An <see cref="IActionResult"/> representing the product details view.</returns>
        public IActionResult ProductDetails(int id)
        {
            _logger.LogInformation("Attempting to retrieve details for product with ID: {ProductId}", id);

            try
            {
                var products = _productService.GetProductDetails(id).ToList();

                if (!products.Any())
                {
                    _logger.LogWarning("Product with ID {ProductId} not found.", id);
                    return NotFound($"Product with ID {id} not found.");
                }

                // The ProductDetails view expects a HomeIndexViewModel, populating only the Products property
                var model = new HomeIndexViewModel
                {
                    Products = products
                };

                _logger.LogInformation("Successfully retrieved details for product with ID: {ProductId}", id);
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving details for product with ID: {ProductId}", id);
                return StatusCode(500, $"An error occurred while loading details for product ID {id}.");
            }
        }
    }
}using MarktVille.Models;
using MarktVille.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace MarktVille.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger