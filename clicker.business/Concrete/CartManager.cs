using System.Text;
using clicker.business.Abstract;
using clicker.data.Abstract;
using clicker.entity;


namespace clicker.business.Concrete
{
    public class CartManager : ICartService
    {
        
     private ICartRepository _cartRepository;

     public CartManager(ICartRepository cartRepository)
     {
         _cartRepository=cartRepository;
         
     }

        public void AddToCart(string userId, int productId, int quantity)
        {
           var cart=GetCartByUserId(userId);
           if (cart!=null)
           {
               var index=cart.CartItems.FindIndex(i=>i.ProductId==productId);
               if (index<0)
               {
                   cart.CartItems.Add(new CartItem(){
                       ProductId=productId,
                       Quantity=quantity,
                       CartId=cart.Id
                   });
                   
               }
               else
               {
                   cart.CartItems[index].Quantity+=quantity;
               }

               
           }
         
        }

        public void ClearCart(int cartId)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteFromCart(string userId, int productId)
        {
            throw new System.NotImplementedException();
        }

        public Cart GetCartByUserId(string userId)
        {
            return  _cartRepository.GetCartByUserId(userId);
            
        }

        public void InitilaizeCart(string userId)
        {
            throw new System.NotImplementedException();
        }
    }
}