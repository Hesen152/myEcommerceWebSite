using System.Collections.Generic;
using clicker.entity;

namespace clicker.business.Abstract
{
    public interface ICategoryService:IValid<Category>
    {
             Category GetById(int Id);

             List<Category> GetAll();


             void Create(Category entity);

             void Update(Category entity);

             void Delete(Category entity);
             Category GetByIdWithProducts(int categoryId);

             void DeleteFromCategory(int categoryId,int productId);
    }
}