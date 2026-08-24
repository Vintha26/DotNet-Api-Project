using DotNetApi.Model;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Shipper> Shippers { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
    }
}