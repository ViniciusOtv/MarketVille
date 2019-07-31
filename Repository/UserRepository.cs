using Dapper;
using MarktVille.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MarktVille.Repository
{
    public class UserRepository : IUserRepository
    {

        public UserRepository(IConfiguration configuration)
        {
            _config = configuration;

        }

        private IConfiguration _config;
        private List<User> _user;

        public IEnumerable<User> GetUser()
        {

            using (var connection = new SqlConnection(
                _config.GetConnectionString("Ville_dev")))
            {
                try
                {
                    var query = connection.Query<User>(
                   "SELECT * FROM dbo.Users ORDER BY UserId Desc;");
                    _user = query.ToList();
                    return _user;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public IEnumerable<User> GetUserById(int? id)
        {
            using (var connection = new SqlConnection(
                 _config.GetConnectionString("Ville_dev")))
            {
                try
                {
                    var query = connection.Query<User>(
                   "SELECT * FROM dbo.Users WHERE UserId = @UserId",
                    new { @UserId = id});

                    _user = query.ToList();
                    return _user;

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
