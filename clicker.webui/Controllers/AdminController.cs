using System.Reflection.Emit;
using System.Reflection;
using System.Xml.Schema;
using System.IO;
using System.Linq;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Net.Security;
using System.Data;
using clicker.business.Abstract;
using clicker.entity;
using clicker.webui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using clicker.webui.Identity;
using Microsoft.AspNetCore.Authorization;

namespace clicker.webui.Controllers
{
        
            // [Authorize(Roles="admin")]

    public class AdminController : Controller
    {

        private IProductService _productService;
        private ICategoryService _categoryService;
         private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;


        public AdminController(IProductService productService, ICategoryService categoryService
        ,
                        RoleManager<IdentityRole> roleManager,
                        UserManager<User> userManager)
        {
            _productService = productService;
            _categoryService = categoryService;
                _roleManager = roleManager;
            _userManager=userManager;

        }

          




       public IActionResult UserList()
       {
          
           return View(_userManager.Users);
       }

    //    public async Task<IActionResult> UserEdit(string id)
    //    {
    //        var user=await _userManager.FindByIdAsync(id);
    //        if (user!=null)
    //        {

               
    //        }

    //    }



       public IActionResult RoleList()

       {
           return View(_roleManager.Roles);
       }

      

        [HttpGet]
        public IActionResult CreateCategory()
        {

            return View();
        }

        public IActionResult CategoryList()
        {
            return View(new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll()
            });

        }

        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Name = model.Name,
                    Url = model.Url
                };

                _categoryService.Create(entity);



            }
            return RedirectToAction("CategoryList");

        }

        public IActionResult EditCategory(int? id)
        {
            if (id==null)
            {
                return NotFound();
                

            }

            var entity=_categoryService.GetByIdWithProducts((int)id);
            if (entity==null)
            {
                return NotFound();
                
            }

            var model=new CategoryModel()
            {
                CategoryId=entity.CategoryId,
                Name=entity.Name,
                Url=entity.Url,
                Products=entity.ProductCategories.Select(c=>c.Product).ToList()
            };

            return View(model);



        }
        [HttpPost]
          public IActionResult EditCategory(CategoryModel model)
        {

            if (ModelState.IsValid)
            {
                var entity=_categoryService.GetById(model.CategoryId);

                if (entity==null)
                {
                   
                    return NotFound();
                }
                 entity.Name=model.Name;
                    entity.Url=model.Url;
                    _categoryService.Update(entity);

            
            return RedirectToAction("CategoryList");


            }
            return View(model);





        }

        [HttpGet]
        public IActionResult EditProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var entity = _productService.GetByWidthCategories((int)id);

            if (entity == null)
            {
                return NotFound();

            }

            var model = new ProductModel()
            {

                ProductId = entity.ProductId,
                Name = entity.Name,
                Url = entity.Url,
                Price = entity.Price,
                ImageUrl = entity.ImageUrl,
                Description = entity.Description,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                SelectedCategories = entity.ProductCategories.Select(i => i.Category).ToList()


            };

            ViewBag.Categories = _categoryService.GetAll();

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductModel model, int[] categoryIds, IFormFile file)
        {

            if (ModelState.IsValid)
            {
                var entity = _productService.GetById(model.ProductId);

                if (entity == null)
                {
                    return NotFound();

                }
                entity.Name = model.Name;
                entity.Price = model.Price;
                entity.Url = model.Url;
                entity.Description = model.Description;
                entity.IsHome = model.IsHome;
                entity.IsApproved = model.IsApproved;
                if (file != null)
                {
                    var exten = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{exten}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);

                    }


                }





                if (_productService.Update(entity, categoryIds))
                {


                    return RedirectToAction("ProductList");
                }



            }

            ViewBag.Categories = _categoryService.GetAll();
            return View(model);

        }





        public IActionResult ProductList()

        {
            return View(new ProductListViewModel()
            {
                Products = _productService.GetAll()

            });



        }


       

        
         



        public async Task<IActionResult> CreateProduct(ProductModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
               
                  var entity = new Product()
                {
                    Name = model.Name,
                    Url = model.Url,
                    Price = model.Price,
                    Description = model.Description,
                     
                    //  if (file!=null)
                    //  {
                    //         var extention = Path.GetExtension(file.FileName);
                    // var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                         
                    //  }

                };


                //   if (_productService.Create(entity))
                //   {
                //       TempData.Put("message",new MessageExplanation(){
                //          Title="Elave Edildi!",
                //          Message="Elave Olundu"


                //       });

                //       return RedirectToAction("ProductList");


                //   }
                //   TempData.Put("message",new  MessageExplanation(){

                //   });

                if (_productService.Create(entity))
                {

                    return RedirectToAction("ProductList");

                }
                else
                {

                    return View(model);

                }




            }


            return View(model);


        }

        
                // private async Task<string>  UploadedFile(ProductModel model,IFormFile file)

                // {
                //         var extention = Path.GetExtension(file.FileName);
                //     var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                //     model.ImageUrl = randomName;
                //     var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);
                //     using (var stream = new FileStream(path, FileMode.Create))
                //     {
                //         await file.CopyToAsync(stream);

                //     }

                //     return randomName;



                // }  


        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);

            if (entity != null)
            {
                _productService.Delete(entity);

            }
            var message=new MessageExplanation()
            {
                Message=$"{entity.Name} Adli mehsul silindi",
                AlertType="warning"

            };

            TempData["message"]=JsonConvert.SerializeObject(message);


            return RedirectToAction("ProductList");




        }


        public IActionResult DeleteCategory(int categoryId)
        {
            var entity=_categoryService.GetById(categoryId);

            if (entity!=null)
            {
                _categoryService.Delete(entity);
                  

               }


                  return RedirectToAction("CategoryList");
                
           
        }

          [HttpPost]
        public IActionResult DeleteFromCategory(int productId,int categoryId)
         {
             _categoryService.DeleteFromCategory(productId,categoryId);

             return Redirect("/admin/categories/"+categoryId);
            

         }



    }
}