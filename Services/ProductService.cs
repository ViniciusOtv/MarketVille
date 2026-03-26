using MarktVille.Models;
using MarktVille.Repository;
using MarktVille.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace MarktVille.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Product> GetAllProducts()
        {
            _logger.LogInformation("Attempting to retrieve all products.");
            try
            {
                var products = _productRepository.GetAllProducts();
                _logger.LogInformation("Successfully retrieved all products.");
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving all products.");
                throw; // Re-throw the exception after logging
            }
        }

        public IEnumerable<Product> GetProductById(int id)
        {
            _logger.LogInformation("Attempting to retrieve product with ID: {ProductId}", id);
            try
            {
                var products = _productRepository.GetProductById(id);
                _logger.LogInformation("Successfully retrieved product with ID: {ProductId}", id);
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving product with ID: {ProductId}", id);
                throw;
            }
        }

        public IEnumerable<Product> GetProductForCarousel()
        {
            _logger.LogInformation("Attempting to retrieve products for carousel.");
            try
            {
                var products = _productRepository.GetProductForCarousel();
                _logger.LogInformation("Successfully retrieved products for carousel.");
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving products for carousel.");
                throw;
            }
        }

        public IEnumerable<Product> GetProductStore(int id)
        {
            _logger.LogInformation("Attempting to retrieve products for store with ID: {StoreId}", id);
            try
            {
                var products = _productRepository.GetProductStore(id);
                _logger.LogInformation("Successfully retrieved products for store with ID: {StoreId}", id);
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving products for store with ID: {StoreId}", id);
                throw;
            }
        }
    }
}