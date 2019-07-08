using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarktVille.DAL;
using MarktVille.Models;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace MarktVille.Controllers
{
    public class ProductDetailController : Controller
    {

        private IConfiguration _config;
        private List<Product> _product;


        public ProductDetailController(IConfiguration configuration)
        {
            _config = configuration;
        }
        public IEnumerable<Product> GetAllProducts()
        {

            using (SqlConnection connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {

                var pro = connection.Query<Product>(
                    "SELECT * FROM dbo.Products");

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

        public IActionResult Index(int id)
        {

            GetProductById(id);
            var model = new HomeIndexViewModel();
            model.Products = _product;
         
            return View(model);
        }
    }
}