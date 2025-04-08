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
     
    }
}
