using clicker.business.Abstract;
using clicker.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace clicker.webui.Controllers
{
    public class HomeController:Controller
    {
          private IProductService _productService;

        public HomeController(IProductService productService)
        {
         _productService=productService;
        }

        
         public IActionResult Index()
         {
           var productViewModel=new ProductListViewModel(){
               Products=_productService.GetAll()
           };

           return View(productViewModel);
         }
    }
}