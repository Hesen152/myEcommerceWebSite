using System.Reflection.Metadata.Ecma335;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace clicker.webui.Models
{
    public class CartModel
    {   
        public int CartId { get; set; }

        public List<CartItemModel> CartItems {get;set;}

        public double TotalPrice()
        {
            return CartItems.Sum(i=>i.Price*i.Quantity);
        }
       
        
    }
}