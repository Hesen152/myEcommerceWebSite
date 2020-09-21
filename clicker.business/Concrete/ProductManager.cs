using System.Reflection;
using System.Collections.Generic;
using clicker.business.Abstract;
using clicker.data.Abstract;
using clicker.entity;

namespace clicker.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository )
        {
            _productRepository=productRepository;
            
        }

        public string ErrorMessage { get ; set; }

        public bool Create(Product entity)
        {
            
               _productRepository.Create(entity);
            
           
                
            return true;
           
           
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return  _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }



        public Product GetByWidthCategories(int id)
        {
           return  _productRepository.GetByWidthCategories(id);
        }

        public int GetCountByCategory(string category)
        {
           return _productRepository.GetCountByCategory(category);
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductsDetails(url);
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _productRepository.GetProductsByCategory(name,page,pageSize);
        }

        public List<Product> GetSearch(string search)
        {
            return _productRepository.GetSearch(search);
        }

      

        public void Update(Product entity)
        {
             _productRepository.Update(entity);
        }

        public bool Valdiation(Product entity)
        {
            throw new System.NotImplementedException();
        }

       public  bool Update(Product entity, int[] categoryIds)
        {
            //  if (categoryIds.Length==0)
            //  {
            //      ErrorMessage+="Mehsul ucun minimum 1 kategoriya secin";
            //     //  return false;
                 
            //  }
              _productRepository.Update(entity,categoryIds);
              return true;
       
        }
    }
}