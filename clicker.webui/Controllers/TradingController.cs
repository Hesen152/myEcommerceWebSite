using clicker.business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace clicker.webui.Controllers
{
    public class TradingController:Controller
    {
        private IProductService _productService;
        
        public TradingController(IProductService productService)
        {
             _productService=productService;
            
        }


        public IActionResult List()
        {

            return View();

        }




        
    }
}