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

            using (SqlConnection connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {

                var pro = connection.Query<Product>(
                    "SELECT * FROM dbo.Products ORDER BY ProductId desc;");

                _product = pro.ToList();
                return _product;
            }

        }
        public IEnumerable<Product> GetProductById(int id)
        {
            using (SqlConnection connection = new SqlConnection(
              _config.GetConnectionString("Ville_dev")))
            {

                var pro = connection.Query<Product>(
                    "SELECT * FROM dbo.Products WHERE ProductId = @ProductId",
                    new { @ProductId = id });

                _product = pro.ToList();
                return _product;
            }

        }
       
    }
}
