using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class HomeIndexViewModel
    {
        public List<Product> Products { get; set; }

        public List<Category> Categories { get; set; }

        public List<SubCategory> SubCategories { get; set; }

        public List<Supplier> Suppliers { get; set; }

        public List<Store> Stores { get; set; }

        public List<Location> Locations { get; set; }

        public List<ProductDetail> ProductDetails { get; set; }

        public List<User> Users { get; set; }

        public List<UserDetail> UserDetails { get; set; }

    }
}
