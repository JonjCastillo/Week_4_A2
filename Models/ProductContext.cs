using Microsoft.EntityFrameworkCore;

namespace SportsPro.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    ProductId = 1,
                    ProductCode = "TRNY10",
                    Name = "Tournament Master 1.0",
                    Price = 4.99M,
                    ReleaseDate = new DateTime(2018, 12, 01)
                },
                new Product
                {
                    ProductId = 2,
                    ProductCode = "LEAG10",
                    Name = "League Scheduler 1.0",
                    Price = 4.99M,
                    ReleaseDate = new DateTime(2019, 05, 01)
                },

                new Product
                {
                    ProductId = 3,
                    ProductCode = "LEAGD10",
                    Name = "League Scheduler Deluxe 1.0",
                    Price = 7.99M,
                    ReleaseDate = new DateTime(2019, 08, 01)
                },

                new Product
                {
                    ProductId = 4,
                    ProductCode = "TEAM10",
                    Name = "Team Manager 1.0",
                    Price = 4.99M,
                    ReleaseDate = new DateTime(2020, 05, 01)
                },

                new Product
                {
                    ProductId = 5,
                    ProductCode = "TRNY20",
                    Name = "Tournament Master 2.0",
                    Price = 5.99M,
                    ReleaseDate = new DateTime(2021, 02, 15)
                },

                new Product
                {
                    ProductId = 6,
                    ProductCode = "DRAFT20",
                    Name = "Draft Manager 2.0",
                    Price = 5.99M,
                    ReleaseDate = new DateTime(2022, 07, 15)
                }



                );
        }

    }
}
