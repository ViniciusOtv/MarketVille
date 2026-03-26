using MarktVille.Models;
using System.Collections.Generic;

namespace MarktVille.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductById(int id);
        IEnumerable<Product> GetProductForCarousel();
        IEnumerable<Product> GetProductStore(int id);
    }
}