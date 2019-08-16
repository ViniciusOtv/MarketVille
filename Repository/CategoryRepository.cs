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
    public class CategoryRepository : ICategoryRepository
    {
        IConfiguration _config;
        List<Category> _category;
        List<SubCategory> _subCat;


        public CategoryRepository(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IEnumerable<Category> GetAllCategories()
        {

            using (var connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                try
                {
                    var query = connection.Query<Category>(
                    "SELECT * FROM dbo.Categories ");
                    _category = query.ToList();
                    return _category;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }



        //public IEnumerable<Category> GetSubcategories()
        //{
        //    using (var connection = new SqlConnection(
        //       _config.GetConnectionString("Ville_dev")))
        //    {
        //        var query = connection.Query<Category, SubCategory>(
        //            "Select S.SubCategoryId, " +
        //            "C.CategoryId," +
        //            " C.Name, " +
        //            "S.Name " +
        //            "FROM Categories as C" +
        //            "INNER JOIN SubCategory as S on C.CategoryId = S.CategoryId"
        //            );
        //    }

        //}

    }
}
