using System.Text;
using clicker.entity;

namespace clicker.business.Abstract
{
    public interface ICartService
    {
        void InitilaizeCart(string userId);
        Cart GetCartByUserId(string userId);
        void AddToCart(string userId,int productId,int quantity);
        void DeleteFromCart(string userId,int productId);

        void ClearCart(int cartId);
        
    }
}