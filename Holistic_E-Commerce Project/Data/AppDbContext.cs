using Holistic_E_Commerce_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Holistic_E_Commerce_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shopping_Cart> Shopping_Carts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
