using System.Diagnostics;
using clicker.entity;
using Microsoft.EntityFrameworkCore;

namespace clicker.data.Concrete.EfCore
{
    public class ClickerContext:DbContext
    {

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         optionsBuilder.UseSqlite("Data Source=clickeDb");
     }


           protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               modelBuilder.Entity<ProductCategory>().HasKey(c=>new {c.CategoryId,c.ProductId});
               
          }
            

          public DbSet<Product> Products { get; set; }

          public DbSet<Category> Categories { get; set; }


    }
}