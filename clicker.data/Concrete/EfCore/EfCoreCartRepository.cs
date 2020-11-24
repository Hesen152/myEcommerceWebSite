using System.IO;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Reflection;
using System.Threading;
using System;
using clicker.data.Abstract;
using clicker.entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace clicker.data.Concrete.EfCore
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart, ClickerContext>, ICartRepository
    {
        public void ClearCart(int cartId)
        {
            
        }

        public void DeleteFromCart(int catId, int productId)
        {
            throw new System.NotImplementedException();
        }

        public Cart GetCartByUserId(string userId)
        {
            using (var context=new ClickerContext())
            {
                return context.Carts
                .Include(i=>i.CartItems)
                .ThenInclude(i=>i.Product)
                .FirstOrDefault();
                
            }

        }
    }
}