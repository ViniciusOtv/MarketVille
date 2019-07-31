using Dapper;
using MarktVille.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Repository
{
    public class ProductRepository : IProductRepository
    {

        private IConfiguration _config;
        private List<Product> _product;
       
        public ProductRepository(IConfiguration configuration)
        {
            _config = configuration;
        }
        public IEnumerable<Product> GetAllProducts()
        {

            using (var connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                try
                {
                    var query = connection.Query<Product>(
                   "Select S.Name, P.ProductId, p.Name, p.ShortDescription, p.Details, P.Image, " +
                   "p.SellingPrice from Products as P JOIN Stores as S on P.StoreId = S.StoreId order by P.ProductId desc");
                    _product = query.ToList();
                    return _product;

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
        public IEnumerable<Product> GetProductById(int id)
        {
            using (var connection = new SqlConnection(
              _config.GetConnectionString("Ville_dev")))
            {

                var pro = connection.Query<Product>(
                    "SELECT * FROM dbo.Products WHERE ProductId = @ProductId",
                    new { @ProductId = id });

                _product = pro.ToList();
                return _product;
            }

        }

        public IEnumerable<Product> GetProductForCarousel()
        {
            using (var connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                var prd = connection.Query<Product>(
                    "SELECT TOP 10 ProductId, Name, SellingPrice, Image FROM dbo.Products ORDER BY ProductId");
                _product = prd.ToList();
                return _product;
            }
        }

        public IEnumerable<Product> GetProductStore(int id)
        {
            using (var connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                var productStore = connection.Query<Product>(
                    "Select * from dbo.Products WHERE StoreId = @StoreId",
                    new { @StoreId = id });

                _product = productStore.ToList();

                return _product;
            }
        }

    }
}
