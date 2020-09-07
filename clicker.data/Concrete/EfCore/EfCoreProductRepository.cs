using clicker.data.Abstract;
using clicker.entity;

namespace clicker.data.Concrete.EfCore
{
    public class EfCoreProductRepository:EfCoreGenericRepository<Product,ClickerContext>,IProductRepository
    {
        
    }
}