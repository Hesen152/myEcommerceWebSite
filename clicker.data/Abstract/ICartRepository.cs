using clicker.entity;

namespace clicker.data.Abstract
{
    public interface ICartRepository:IRepository<Cart>
    {
        Cart GetCartByUserId(string userId);
        void DeleteFromCart(int catId,int productId);

        void ClearCart(int cartId);

        
        
        
    }
}