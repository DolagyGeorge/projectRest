using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class ResturantdbContext: DbContext
    {
        public ResturantdbContext(DbContextOptions<ResturantdbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
