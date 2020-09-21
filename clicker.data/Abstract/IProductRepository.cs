
using System.Collections.Generic;
using clicker.entity;
namespace clicker.data.Abstract
{

    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductsDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);
        List<Product> GetSearch(string search);
        Product GetByWidthCategories(int id);
        void Update(Product entity,int[] categoryIds);
       
    }
}