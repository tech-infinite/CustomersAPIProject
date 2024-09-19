using CustomersAPIProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomersAPIProject.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = 1,
                    Name = "Mike Smith",
                    Address = "1 Wall Street",
                    Email = "msmith@gmail.com",
                    Phone = "0800 750 2219"
                },
                new Customer
                {
                    CustomerID = 2,
                    Name = "John Hill",
                    Address = "10 Swiss Cottage Street",
                    Email = "jsmith@gmail.com",
                    Phone = "0800 750 2219"
                },
                new Customer
                {
                    CustomerID = 3,
                    Name = "Tom Davis",
                    Address = "15 Logan Road",
                    Email = "tdavis@gmail.com",
                    Phone = "0800 750 2219"
                },
                new Customer
                {
                    CustomerID = 4,
                    Name = "Will Brown",
                    Address = "12 Forest Street",
                    Email = "willb@yahoo.com",
                    Phone = "0800 750 2219"
                },
                new Customer
                {
                    CustomerID = 5,
                    Name = "Jess Smith",
                    Address = "20 Fenchurch Road",
                    Email = "jsmith@yahoo.com",
                    Phone = "0800 750 2219"
                },
                new Customer
                {
                    CustomerID = 6,
                    Name = "Kate Mills",
                    Address = "25 Greenhill Lane",
                    Email = "jnmiills@gmail.com",
                    Phone = "0800 750 2219"
                }
    
            );
        }
    }
}
