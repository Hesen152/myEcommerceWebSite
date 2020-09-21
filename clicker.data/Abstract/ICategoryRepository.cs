using clicker.entity;
namespace clicker.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
      Category  GetByIdWithProducts(int categoryId);
      void DeleteFromCategory(int productId,int categoryId);
    }
}