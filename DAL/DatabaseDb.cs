using MarktVille.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.DAL
{
    public class DatabaseDb : DbContext
    {
        public DatabaseDb(DbContextOptions<DatabaseDb> options) :
            base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<SubCategory> SubCategory { get; set; }
    }

}
