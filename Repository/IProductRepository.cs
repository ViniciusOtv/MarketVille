using MarktVille.Models;
using System.Collections.Generic;

namespace MarktVille.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetProductById(int id);

        IEnumerable<Product> GetProductForCarousel();

        IEnumerable<Product> GetProductStore(int id);
    }
}
