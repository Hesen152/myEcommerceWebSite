using System.Collections.Generic;

namespace clicker.data.Abstract
{
    public interface IRepository<T>
    {

        T GetById(int Id);
        List<T> GetAll();

        void Update(T entity);

        void Create(T entity);

        void Delete(T entity);

         
    }
}