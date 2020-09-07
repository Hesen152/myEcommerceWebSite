using System.Runtime.CompilerServices;
using clicker.data.Abstract;
using clicker.entity;

namespace clicker.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository:EfCoreGenericRepository<Category,ClickerContext>,ICategoryRepository
    {
        
    }
}