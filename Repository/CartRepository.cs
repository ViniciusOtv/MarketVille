using MarktVille.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Repository
{
    public class CartRepository
    {
        private IConfiguration _config;
        private List<Cart> _cart;
        private List<User> _user; 


        public CartRepository(IConfiguration configuration)
        {
            _config = configuration; 
        }

        public IEnumerable<Cart> GetCartUser()
        {
            return _cart;
        }

    }


}
