using MarktVille.Models;
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
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly ILogger _logger;

        public ProductService(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            ISubCategoryRepository subCategoryRepository,
            ILogger logger)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _subCategoryRepository = subCategoryRepository ?? throw new ArgumentNullException(nameof(subCategoryRepository));
            _logger = logger.ForContext<ProductService>() ?? throw new ArgumentNullException(nameof(logger));
        }

        public HomeIndexViewModel GetHomeIndexViewModelData()
        {
            _logger.Information("Attempting to retrieve data for Home Index ViewModel.");
            try
            {
                var model = new HomeIndexViewModel();

                model.Products = _productRepository.GetAllProducts()?.ToList() ?? new List<Product>();
                _logger.Debug("Retrieved {ProductCount} products.", model.Products.Count);

                model.Categories = _categoryRepository.GetAllCategories()?.ToList() ?? new List<Category>();
                _logger.Debug("Retrieved {CategoryCount} categories.", model.Categories.Count);

                var allSubCategories = new List<SubCategory>();
                foreach (var category in model.Categories)
                {
                    var subCategoriesForCategory = _subCategoryRepository.GetSubCategorieByCategoryId(category.CategoryId)?.ToList();
                    if (subCategoriesForCategory != null)
                    {
                        allSubCategories.AddRange(subCategoriesForCategory);
                    }
                }
                model.SubCategories = allSubCategories;
                _logger.Debug("Retrieved {SubCategoryCount} subcategories.", model.SubCategories.Count);

                _logger.Information("Successfully retrieved all data for Home Index ViewModel.");
                return model;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while retrieving data for Home Index ViewModel.");
                throw; // Re-throw the exception after logging
            }
        }

        public Product GetProductDetails(int productId)
        {
            _logger.Information("Attempting to retrieve details for product with ID: {ProductId}.", productId);
            try
            {
                var product = _productRepository.GetProductById(productId)?.FirstOrDefault();
                if (product == null)
                {
                    _logger.Warning("Product with ID: {ProductId} not found.", productId);
                }
                else
                {
                    _logger.Information("Successfully retrieved details for product with ID: {ProductId}.", productId);
                }
                return product;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while retrieving product details for ID: {ProductId}.", productId);
                throw;
            }
        }

        public IEnumerable<Product> GetProductsForCarousel()
        {
            _logger.Information("Attempting to retrieve products for carousel display.");
            try
            {
                var products = _productRepository.GetProductForCarousel()?.ToList() ?? new List<Product>();
                _logger.Information("Retrieved {ProductCount} products for carousel.", products.Count);
                return products;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while retrieving products for carousel.");
                throw;
            }
        }

        public IEnumerable<Product> GetProductsByStore(int storeId)
        {
            _logger.Information("Attempting to retrieve products for store with ID: {StoreId}.", storeId);
            try
            {
                var products = _productRepository.GetProductStore(storeId)?.ToList() ?? new List<Product>();
                _logger.Information("Retrieved {ProductCount} products for store with ID: {StoreId}.", products.Count, storeId);
                return products;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while retrieving products for store with ID: {StoreId}.", storeId);
                throw;
            }
        }
    }
}