using System.Linq;
using clicker.business.Abstract;
using clicker.entity;
using clicker.webui.Models;
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


        public IActionResult List(string category,int page=1)
        {
            const int pageSize=5;

            var productViewModel=new ProductListViewModel{
                PageInfo=new PageInfo(){
                TotalItems=_productService.GetCountByCategory(category),
                CurrentPage=page,
                ItemsPerPage=pageSize,
                CurrentCategory=category
           

            },
             Products=_productService.GetProductsByCategory(category,page,pageSize)
            };
            return View(productViewModel);

        }



        public IActionResult Details(string url)
        {

            if (url==null)
            {
                return NotFound();
                
            }

            Product product=_productService.GetProductDetails(url);
            if (product==null)
            {
                return NotFound();
                
            }

            return View(
              new ProductDetailModel{
                  Products=product,
                  Categories=product.ProductCategories.Select(i=>i.Category).ToList()
              }


            );  

        }


        public IActionResult SearchAny(string search)
        {
            var productViewModel=new ProductListViewModel{
                Products=_productService.GetSearch(search)
            };

            return View(productViewModel);


        }







        
    }
}