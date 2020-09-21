using System.Collections.Generic;
using clicker.entity;

namespace clicker.business.Abstract
{
    public interface IProductService:IValid<Product>
    {

         List<Product> GetAll();

         //sonra bool et ve ProductManagerde bool gozdeyerek Validationdan kecir sehvleri gormek ucun 
        bool Create(Product entity);

        Product GetProductDetails(string url);

        List<Product> GetProductsByCategory(string name,int page,int pageSize);

         int GetCountByCategory(string category);

        void Delete(Product entity);
         void Update(Product entity);
        bool Update(Product entity,int[] categoryIds);


        List<Product> GetSearch(string search);
        Product GetByWidthCategories(int id);
        Product GetById(int id);
    }
}