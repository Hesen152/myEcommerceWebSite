using System.Runtime.InteropServices.WindowsRuntime;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using clicker.business.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using clicker.webui.Identity;
using clicker.webui.Models;
using System.Linq;

namespace clicker.webui.Controllers
{
    [Authorize]
    public class CartController:Controller
    {
        private ICartService _cartService;
         
         private UserManager<User> _userManager;
        
        public CartController(ICartService cartService,UserManager<User> userManager)
        {
            _cartService=cartService;
            _userManager=userManager;

            
        }

        public IActionResult Index()
        {
            
          var cart=_cartService.GetCartByUserId(_userManager.GetUserId(User));
          return View(new CartModel(){
              CartId=cart.Id,
              CartItems=cart.CartItems.Select(i=>new CartItemModel()
              {
                CartItemId=i.Id,
                ProductId=i.ProductId,
                Name=i.Product.Name,
                Price=(double)i.Product.Price,
                ImageUrl=i.Product.ImageUrl,
                Quantity=i.Quantity
                  
              }).ToList()

              
          });





        }

        public IActionResult AddToCart(int productId,int quantity)
        {
          var  userId=_userManager.GetUserId(User);
          _cartService.AddToCart(userId,productId,quantity);
          return RedirectToAction("Index");
        }

        






    




        
    }
}