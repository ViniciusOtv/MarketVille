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
        private IConfiguration _config;
        private List<SubCategory> _subCat;

        public SubCategoryRepository(IConfiguration configuration)
        {
            _config = configuration;
        }
        public IEnumerable<SubCategory> GetSubCategorieByCategoryId(int id)
        {
            using (var connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                try
                {
                    var query = connection.Query<SubCategory>(
                        "SELECT * FROM dbo.SubCategory WHERE CategoryId = @CategoryId",
                        new { @CategoryId = id });

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