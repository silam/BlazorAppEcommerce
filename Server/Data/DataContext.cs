using Microsoft.EntityFrameworkCore;
using UNet7BlazorAppEcomm.Shared;

namespace BlazorAppEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Mastering Blockchain - Third Edition",
                        Description = "A deep dive into distributed ledgers, consensus protocols, smart contracts, DApps, cryptocurrencies, Ethereum, and more 3rd ed. Edition",
                        Price = 9.99m,
                        ImageUrl = "https://m.media-amazon.com/images/I/71sZn444OfL._SL1360_.jpg"
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Azure SQL Revealed",
                        Description = "A Guide to the Cloud for SQL Server Professionals 1st ed. Edition, Kindle Edition",
                        Price = 90.99m,
                        ImageUrl = "https://m.media-amazon.com/images/I/61kXeAWGSbL._SL1180_.jpg"
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Algorithms and Data Structures with Python",
                        Description = "An interactive learning experience: Comprehensive introduction to data structures and algorithms (Spanish Edition) Kindle Edition",
                        Price = 19.99m,
                        ImageUrl = "https://m.media-amazon.com/images/I/81Xp21sgKIL._SL1500_.jpg"
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "System Design Interview",
                        Description = "System design questions are often the most difficult of all technical interview questions. This book makes them easier to tackle. It is Volume 1 of the ‘System Design Interview - An Insider’s Guide’ series",
                        ImageUrl = "https://m.media-amazon.com/images/I/615KGTRs1OL._SL1500_.jpg",
                        Price = 39.99m
                    }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
