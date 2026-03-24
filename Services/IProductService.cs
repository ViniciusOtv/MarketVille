using MarktVille.Models;
using System.Collections.Generic;

namespace MarktVille.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Retrieves all data required for the Home Index page, including products, categories, and subcategories.
        /// This method orchestrates calls to respective repositories to compose the HomeIndexViewModel.
        /// </summary>
        /// <returns>A HomeIndexViewModel containing aggregated data for the home page.</returns>
        HomeIndexViewModel GetHomeIndexViewModelData();

        /// <summary>
        /// Retrieves details for a specific product by its ID.
        /// </summary>
        /// <param name="productId">The ID of the product to retrieve.</param>
        /// <returns>A Product object containing the details of the requested product, or null if not found.</returns>
        Product GetProductDetails(int productId);

        /// <summary>
        /// Retrieves a collection of products suitable for display in a carousel.
        /// </summary>
        /// <returns>An enumerable collection of Product objects for carousel display.</returns>
        IEnumerable<Product> GetProductsForCarousel();

        /// <summary>
        /// Retrieves all products associated with a specific store ID.
        /// </summary>
        /// <param name="storeId">The ID of the store.</param>
        /// <returns>An enumerable collection of Product objects belonging to the specified store.</returns>
        IEnumerable<Product> GetProductsByStore(int storeId);
    }
}