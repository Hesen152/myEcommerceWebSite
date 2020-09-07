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
            throw new System.NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return  _productRepository.GetAll();
        }

        public bool Update(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Valdiation(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}