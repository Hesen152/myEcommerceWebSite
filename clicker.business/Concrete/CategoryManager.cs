using System.Collections.Generic;
using clicker.business.Abstract;
using clicker.data.Abstract;
using clicker.entity;

namespace clicker.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository=categoryRepository;
        }
        public string ErrorMessage { get ; set ; }

        public void Create(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
            
        }

        public Category GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Valdiation(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}