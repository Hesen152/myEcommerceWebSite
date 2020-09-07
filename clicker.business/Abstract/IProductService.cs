using System.Collections.Generic;
using clicker.entity;

namespace clicker.business.Abstract
{
    public interface IProductService:IValidator<Product>
    {

         List<Product> GetAll();
        bool Create(Product entity);

        void Delete(Product entity);

        bool Update(Product entity);


         
    }
}