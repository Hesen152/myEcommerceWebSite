using System.Xml.Schema;
using System.Collections.Generic;
using System.Linq;
using clicker.data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace clicker.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
     where TEntity : class
     where TContext : ClickerContext, new()
    {
        public void Create(TEntity entity)
        {
            using (var context=new ClickerContext())
            {
               context.Set<TEntity>().Add(entity);
               context.SaveChanges();            }
        }

        public void Delete(TEntity entity)
        {
           using (var context=new ClickerContext())
            {
               context.Set<TEntity>().Remove(entity);
               context.SaveChanges();
                
            }
        }

        public List<TEntity> GetAll()
        {
        using (var context=new ClickerContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int Id)
        {
            using (var context=new ClickerContext())
            {
                 return context.Set<TEntity>().Find(Id);
                
            }
        }

        public void Update(TEntity entity)
        {
             using (var context=new ClickerContext())
            {
             context.Entry(entity).State=EntityState.Modified;
             context.SaveChanges();
            }
        }
    }
}