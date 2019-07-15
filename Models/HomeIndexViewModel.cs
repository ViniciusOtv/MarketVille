using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class HomeIndexViewModel
    {
        public List<Product> Products { get; set; }

        public Category[] Categories { get; set; }

        public Supplier[] Suppliers { get; set; }

        public List<Store> Stores { get; set; }

        public Location[] Locations { get; set; }

        public ProductDetail[] ProductDetails { get; set; }

        public int SelectStore { get; set; }
    }
}
