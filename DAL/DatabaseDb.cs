using MarktVille.Models;
using Microsoft.EntityFrameworkCore;


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

        public DbSet<Cart> Cart { get; set; }

        public DbSet<CartItem> CartItem { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<UserDetail> UserDetail { get; set; }

    }

}
