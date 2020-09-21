using System;
using System.Diagnostics;
using clicker.entity;
using Microsoft.EntityFrameworkCore;

namespace clicker.data.Concrete.EfCore
{
    public class ClickerContext:DbContext
    {


     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         optionsBuilder.UseSqlite("Data Source=clickerDb");

         
     }


           protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               modelBuilder.Entity<ProductCategory>().HasKey(t=>new {t.CategoryId,t.ProductId});
               
          }
            

          public DbSet<Product> Products { get; set; }

          public DbSet<Category> Categories { get; set; }
           
    }
}