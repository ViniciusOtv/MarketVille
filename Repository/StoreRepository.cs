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
    public class StoreRepository : IStoreRepository
    {
        private IConfiguration _config;
        private List<Store> _store;
        private List<Store> _prdStore;
        private List<Store> _topStore;

        private List<Store> _storeLocator;
        public StoreRepository(IConfiguration configuration)
        {
            _config = configuration;
        }
        public IEnumerable<Store> GetAllStores()
        {

            using (SqlConnection connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {

                var selectStore = connection.Query<Store>(
                    "SELECT * FROM dbo.Stores ORDER BY StoreId desc;");

                _store = selectStore.ToList();
                return _store;
            }

        }

        public IEnumerable<Store> GetStoreById(int id)
        {
            using (SqlConnection connection = new SqlConnection(
              _config.GetConnectionString("Ville_dev")))
            {

                var pro = connection.Query<Store>(
                    "SELECT * FROM dbo.Stores WHERE StoreId = @StoreId",
                    new { @StoreId = id });

                _prdStore = pro.ToList();
                return _prdStore;
            }

        }


        public IEnumerable<Store> GetTopStore()
        {
            using (SqlConnection connection = new SqlConnection(
               _config.GetConnectionString("Ville_dev")))
            {
                var topStore = connection.Query<Store>(
                    "Select top 4 * from dbo.Stores ORDER BY StoreId DESC;");


                _topStore = topStore.ToList();

                return _topStore;
            }
        }

        public IEnumerable<Store> GetStoreByLocationId(int id)
        {

            using (SqlConnection connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                var storeByLocation = connection.Query<Store>(
                    "Select * from Stores where LocationId = @LocationId",
                    new { @LocationId = id });

                _storeLocator = storeByLocation.ToList();

                return _storeLocator;
            }
        }
    }
}
