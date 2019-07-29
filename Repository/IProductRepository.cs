using MarktVille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
