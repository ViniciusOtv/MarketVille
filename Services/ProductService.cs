using MarktVille.Models;
using MarktVille.Repository;
using Serilog;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;using MarktVille.Models;
using MarktVille.Repository;
using Serilog;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductService"/> class.
        /// </summary>
        /// <param name="productRepository">The product repository for data access.</param>
        /// <param name="categoryRepository">The category repository for data access.</param>
        /// <param name="subCategoryRepository">The subcategory repository for data access.</param>
        /// <param name="logger">The logger instance for structured logging.</param>
        public ProductService(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            ISubCategoryRepository subCategoryRepository,
            ILogusing MarktVille.Models;
using MarktVille.Repository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepositoryusing MarktVille.Models;
using MarktVille.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly Iusing MarktVille.Models;
using MarktVille.Repository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepositoryusing MarktVille.Models;
using MarktVille.Repository;
using MarktVille.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            ISubCategoryRepository subCategoryRepository,
            ILogger<ProductService> logger)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _subCategoryRepository = subCategoryRepository ?? throw new ArgumentNullException(nameof(subCategoryRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Retrieves the data required for the home index view, including all products, categories, and subcategories.
        /// This method orchestrates calls to various repositories to assemble the complete view model.
        /// </summary>
        /// <returns>A <see cref="HomeIndexViewModel"/> containing products, categories, and subcategories.</returns>
        public HomeIndexViewModel GetHomeIndexViewModel()
        {
            _logger.LogInformation("Attempting to retrieve data for HomeIndexViewModel.");

            try
            {
                var products = _productRepository.GetAllProducts().ToList();
                _logger.LogDebug("Retrieved {ProductCount} products.", products.Count);

                var categories = _categoryRepository.GetAllCategories().ToList();
                _logger.LogDebug("Retrieved {CategoryCount} categories.", categories.Count);

                var allSubCategories = new List<SubCategory>();
                foreach (var category in categories)
                {
                    var subCategoriesForCategory = _subCategoryRepository.GetSubCategorieByCategoryId(category.CategoryId).ToList();
                    allSubCategories.AddRange(subCategoriesForCategory);
                    _logger.LogDebug("Retrieved {SubCategoryCount} subcategories for category ID {CategoryId}.", subCategoriesForCategory.Count, category.CategoryId);
                }

                var model = new HomeIndexViewModel
                {
                    Products = products,
                    Categories = categories,
                    SubCategories = allSubCategories.DistinctBy(sc => sc.SubCategoryId).ToList() // Ensure unique subcategories if they can appear in multiple categories
                };

                _logger.LogInformation("Successfully assembled HomeIndexViewModel.");
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving data for HomeIndexViewModel.");
                throw; // Re-throw the exception after logging for upstream handling
            }
        }

        /// <summary>
        /// Retrieves a list of products based on the specified product ID for display in product details.
        /// </summary>
        /// <param name="id">The unique identifier of the product to retrieve.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Product"/> objects matching the ID.</returnsusing MarktVille.Models;
using MarktVille.Repository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _using MarktVille.Models;
using MarktVille.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            ISubCategoryRepository subCategoryRepository,
            ILogger<ProductService> logger)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _subCategoryRepository = subCategoryRepository ?? throw new ArgumentNullException(nameof(subCategoryRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Retrieves the data required for the home index view, including all products, categories, and subcategories.
        /// This method orchestrates calls to various repositories to assemble the complete view model.
        /// </summary>
        /// <returns>A <see cref="HomeIndexViewModel"/> containing products, categories, and subcategories.</returns>
        public HomeIndexViewModel GetHomeIndexViewModel()
        {
            _logger.LogInformation("Attempting to retrieve data for HomeIndexViewModel.");
            try
            {
                var model = new HomeIndexViewModel();

                model.Products = _productRepository.GetAllProducts().ToList();
                _logger.LogInformation("Retrieved {ProductCount} products.", model.Products.Count());

                model.Categories = _categoryRepository.GetAllCategories().ToList();
                _logger.LogInformation("Retrieved {CategoryCount} categories.", model.Categories.Count());

                var allSubCategories = new List<SubCategory>();
                foreach (var category in model.Categories)
                {
                    var subCategoriesForCategory = _subCategoryRepository.GetSubCategorieByCategoryId(category.CategoryId).ToList();
                    allSubCategories.AddRange(subCategoriesForCategory);
                    _logger.LogDebug("Retrieved {SubCategoryCount} subcategories for category ID {CategoryId}.", subCategoriesForCategory.Count, category.CategoryId);
                }
                model.SubCategories = allSubCategories;
                _logger.LogInformation("Retrieved a total of {SubCategoryCount} subcategories.", model.SubCategories.Count());

                _logger.LogInformation("Successfully assembled HomeIndexViewModel data.");
                return model;
            }
            catch (Exception ex)
            {using MarktVille.Models;
using MarktVille.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly