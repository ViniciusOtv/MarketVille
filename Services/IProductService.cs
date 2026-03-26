using MarktVille.Models;
using System.Collections.Generic;

namespace MarktVille.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Retrieves all products available.
        /// </summary>
        /// <returns>A collection of all products.</returns>
        IEnumerable<Product> GetAllProducts();

        ///using MarktVille.Models;
using System.Collections.Generic;

namespace MarktVille.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Retrieves the data required for the home index view, including all products, categories, and subcategories.
        /// This method orchestrates calls to various repositories to assemble the complete view model.
        /// </summary>
        /// <returns>A <see cref="HomeIndexViewModel"/> containing products, categories, and subcategories.</returns>
        HomeIndexViewModel GetHomeIndexViewModel();

        /// <summary>
        /// Retrieves a list of products based on the specified product ID for display in product details.
        /// </summary>
        /// <param name="id">The unique identifier of the product to retrieve.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Product"/> objects matching the ID.</returns>
        IEnumerable<Product> GetProductDetails(int id);
    }
}