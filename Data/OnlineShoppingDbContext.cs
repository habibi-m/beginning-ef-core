using _005_beginning_ef_core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _005_beginning_ef_core.Data
{
    public class OnlineShoppingDbContext : DbContext
    {
        public OnlineShoppingDbContext(DbContextOptions<OnlineShoppingDbContext> options)
            : base(options)
        { }


        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // specifying the primary key of the CategoryToProduct
            modelBuilder.Entity<ProductCategory>().HasKey(
                t => new { t.ProductId, t.CategoryId }); // the combination of ProductId and CategoryId will be unique for each CategoryToProduct entry in the table


            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Shoes",
                    Description = "Block Heel Sandal NLY Shoes"
                },
                new Category
                {
                    Id = 2,
                    Name = "Boots",
                    Description = "Comfort Boots"
                },
                new Category
                {
                    Id = 3,
                    Name = "Sneakers",
                    Description = "Popular Sneakers"
                });
        }
    }
}
