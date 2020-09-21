using System.Linq;
using System.Runtime.CompilerServices;
using clicker.data.Abstract;
using clicker.entity;
using Microsoft.EntityFrameworkCore;

namespace clicker.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, ClickerContext>, ICategoryRepository
    {
        //categoriyaya aid mehsullar silmek
        public void DeleteFromCategory(int productId, int categoryId)
        {
            using (var context=new ClickerContext())
            {
               var command="delete from productcategory where ProductId=@p0 and CategoryId=@p1";
                context.Database.ExecuteSqlRaw(command,productId,categoryId);
                

                   
            }

           
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            using (var context=new ClickerContext())
            {
                return context.Categories
                .Where(i=>i.CategoryId==categoryId)
                .Include(i=>i.ProductCategories)
                .ThenInclude(i=>i.Product)
                .FirstOrDefault();
                
                
            }
        }
    }
}