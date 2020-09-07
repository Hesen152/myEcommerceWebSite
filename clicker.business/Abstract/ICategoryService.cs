using System.Collections.Generic;
using clicker.entity;

namespace clicker.business.Abstract
{
    public interface ICategoryService:IValidator<Category>
    {
             Category GetById(int Id);

             List<Category> GetAll();


             void Create(Category entity);

             void Update(Category entity);

             void Remove(Category entity);


    }
}