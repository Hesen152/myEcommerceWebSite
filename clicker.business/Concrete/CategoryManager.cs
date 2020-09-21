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
         _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
           _categoryRepository.Delete(entity);
        }

        public void DeleteFromCategory(int categoryId, int productId)
        {
           _categoryRepository.DeleteFromCategory(categoryId,productId);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
            
        }

        public Category GetById(int Id)
        {
           return _categoryRepository.GetById(Id);
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            return  _categoryRepository.GetByIdWithProducts(categoryId);
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