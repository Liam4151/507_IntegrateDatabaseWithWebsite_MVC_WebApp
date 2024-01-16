using Microsoft.EntityFrameworkCore;
using System;

namespace TypicalTools.Models
{
    public class ContextModel : DbContext
    {
        public ContextModel(DbContextOptions options) : base(options)
        {
            
        }
        /// <summary>
        ///  Database builder that builds each model in database when update-database command is run
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Inital test data inputted
            builder.Entity<Product>().HasData(
                new Product
                {
                    ProductCode = 12345,
                    ProductName = "Generic Headphones",
                    ProductPrice = 84.99m,
                    ProductDescription = "bluetooth headphones with fair battery life and a 1 month warranty",
                    UpdatedDate = DateTime.Now
                },
                new Product 
                {
                    ProductCode = 12346,
                    ProductName = "Expensive Headphones",
                    ProductPrice = 149.99m,
                    ProductDescription = "bluetooth headphones with good battery life and a 6 month warranty",
                    UpdatedDate = DateTime.Now
                },
                new Product
                {
                    ProductCode = 12347,
                    ProductName = "Name Brand Headphones",
                    ProductPrice = 199.99m,
                    ProductDescription = "bluetooth headphones with good battery life and a 12 month warranty",
                    UpdatedDate = DateTime.Now
                },
                new Product
                {
                    ProductCode = 12348,
                    ProductName = "Generic Wireless Mouse",
                    ProductPrice = 39.99m,
                    ProductDescription = "simple bluetooth pointing device",
                    UpdatedDate = DateTime.Now
                },
                new Product
                {
                    ProductCode = 12349,
                    ProductName = "Logitach Mouse and Keyboard",
                    ProductPrice = 73.99m,
                    ProductDescription = "mouse and keyboard wired combination",
                    UpdatedDate = DateTime.Now
                },
                new Product
                {
                    ProductCode = 12350,
                    ProductName = "Logitach Wireless Mouse",
                    ProductPrice = 149.99m,
                    ProductDescription = "quality wireless mouse",
                    UpdatedDate = DateTime.Now
                }
                ) ;
        }
        
        // Retrieves and assigns (gets and sets) the products, comments and adminusers data
        public DbSet<Product> Products { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Admin> AdminUsers { get; set; }
    }
}
