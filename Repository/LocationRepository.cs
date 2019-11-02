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
    public class LocationRepository : ILocationRepository
    {
        private IConfiguration _config;
        private List<Location> _locations;

        public LocationRepository(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IEnumerable<Location> GetAllLocations()
        {

            using (SqlConnection connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {

                var locality = connection.Query<Location>(
                    "SELECT * FROM dbo.Locations ORDER BY LocationId desc;");

                _locations = locality.ToList();
                return _locations;
            }

        }

        public IEnumerable<Location> GetLocalityById(int id)
        {
            using (SqlConnection connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                var locality = connection.Query<Location>(
                    "SELECT * FROM dbo.Locations WHERE LocationId = @LocationId",
                     new { @LocationId = id });

                _locations = locality.ToList();
                return _locations;
            }
        }
    }
}
