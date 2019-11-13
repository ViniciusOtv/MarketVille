using Dapper;
using MarktVille.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace MarktVille.Repository
{

    public class SubCategoryRepository : ISubCategoryRepository
    {

        List<SubCategory> _subCat;
        IConfiguration _config;

        public IEnumerable<SubCategory> GetSubCategorieByCategoryId(List<Category> id)
        {
            using (var connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                try
                {
                    var query = connection.Query<SubCategory>(
                        "SELECT * FROM dbo.SubCategory WHERE CategoryId in @CategoryId",
                        new { @CategoryId = id }).ToList();

                    _subCat = query.ToList();
                    return _subCat;
                }

                catch (Exception)
                {
                    throw;
                }
            }
        }
    }

}