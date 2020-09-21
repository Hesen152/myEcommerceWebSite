using System;
using System.Collections.Generic;
using System.Linq;
using clicker.data.Abstract;
using clicker.entity;
using Microsoft.EntityFrameworkCore;

namespace clicker.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, ClickerContext>, IProductRepository
    {
     

        public Product GetByWidthCategories(int id)
        {
            using (var context=new ClickerContext())
            {
                return context.Products
                .Where(i=>i.ProductId==id)
                .Include(c=>c.ProductCategories)
                .ThenInclude(t=>t.Category)
                .FirstOrDefault();
                
            }
        }

        public int GetCountByCategory(string category)
        {
           using (var context=new ClickerContext())
           {
            var products=context.Products.Where(i=>i.IsApproved).AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                 products=products.
                 Include(i=>i.ProductCategories)
                 .ThenInclude(i=>i.Category)
                 .Where(i=>i.ProductCategories.Any(a=>a.Category.Url==category));
                
            }
            return  products.Count();
               
           }
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            using (var context=new ClickerContext())
            {
                var products=context
                .Products
                .Where(i=>i.IsApproved)
                .AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    products=products
                    .Include(i=>i.ProductCategories)
                    .ThenInclude(i=>i.Category)
                    .Where(i=>i.ProductCategories.Any(c=>c.Category.Url==name));
                    
                }

                return products.Skip((page-1)*pageSize).Take(pageSize).ToList();




                
            }
        }

        public Product GetProductsDetails(string url)
        {
            using (var context=new ClickerContext())
            {
                return context.Products
                .Where(i=>i.Url==url)
                .Include(i=>i.ProductCategories)
                .ThenInclude(i=>i.Category)
                .FirstOrDefault();
                
            }
        }

        public List<Product> GetSearch(string search)
        {
            using (var context=new ClickerContext())
            {

                 var products=context
                 .Products
                 .Where(i=>i.IsApproved && (i.Name.ToLower().Contains(search.ToLower())||i.Description.ToLower().Contains(search.ToLower())))
                  .AsQueryable();


                  return products.ToList();
                
            }
        }
//overloading metod 
        public void Update(Product entity, int[] categoryIds)
        {
            using (var context=new ClickerContext())
            {
               var product=context.Products
               .Include(i=>i.ProductCategories)
                .FirstOrDefault(i=>i.ProductId==entity.ProductId);
                  
                  if (product!=null)
                  {
                      product.Name=entity.Name;
                      product.Price=entity.Price;
                      product.Description=entity.Description;
                      product.Url=entity.Url;
                      product.ImageUrl=entity.ImageUrl;
                      product.IsApproved=entity.IsApproved;
                      product.IsHome=entity.IsHome;

                      product.ProductCategories=categoryIds.Select(categoryId=>new ProductCategory()
                      {
                          ProductId=entity.ProductId,
                          CategoryId=categoryId
                      }).ToList();

                      context.SaveChanges();
                    
                      
                  }



            }
         }
    }
}