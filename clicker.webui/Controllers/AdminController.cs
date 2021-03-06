using System.Reflection.PortableExecutable;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.IO.MemoryMappedFiles;
using System.Buffers;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using System.Net;
using Microsoft.VisualBasic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Xml.Schema;
using clicker.webui.Extend;
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
using clicker.webui.Models;
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


        public IActionResult CreateRole ()
        {
            return View();
        }

        [HttpPost]

        public  async Task<IActionResult> CreateRole(RoleModel model)
        {
            if (ModelState.IsValid)
            {


                var result= await _roleManager.CreateAsync(new IdentityRole(model.RoleName));

                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                    
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                        
                    }
                }

             
       
            }
          return View();
 }
        

        [HttpGet]
        public async Task<IActionResult> RoleEdit(string id)
        {
            var role=await _roleManager.FindByIdAsync(id);
             var members= new List<User>();
             var nonmembers= new List<User>();

             foreach (var user in _userManager.Users)
             {
              var list=  await _userManager.IsInRoleAsync(user,role.Name)?members:nonmembers;
                list.Add(user);
                  }

               var model=new RoleDetails()
               {
                   Role=role,
                   Members=members,
                   NonMembers=nonmembers


               };
               return View(model);



        }



         [HttpPost]
        public async  Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd??new string[]{})
                {
                    var user=await _userManager.FindByIdAsync(userId);

                    if (user!=null)
                    {
                        var result=await _userManager.AddToRoleAsync(user,model.RoleName);

                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("",error.Description);
                                
                            }

                            
                        }
                        
                    }
                    
                }
                foreach (var userId in model.IdsToDelete??new string[]{})
                {
                    var user=await _userManager.FindByIdAsync(userId);
                    if (user!=null)
                    {
                        var result=await _userManager.RemoveFromRoleAsync(user,model.RoleName);

                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("",error.Description);

                                
                            }
                            
                        }
                        
                    }
                    
                }
            }

                return Redirect("/admin/role"+model.RoleId);


        }

        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var role=await _roleManager.FindByIdAsync(roleId);


            var result=await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("RoleList");
                
            }

            return View("RoleList");
             
            

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
        public async Task<IActionResult> EditProduct(ProductModel model,int[] categoryIds, IFormFile file)
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


                if (_productService.Update(entity,categoryIds))
                {

                    TempData.Put("message",new MessageExplanation(){
                        Title="Guncellendi",
                        Message="Mehsul Guncellendi",
                         AlertType="warning"
                    });





                    return RedirectToAction("ProductList");
                }

                TempData.Put("message",new MessageExplanation(){
                  Title="Xeta",
                  Message=_productService.ErrorMessage,
                  AlertType="primary"
                  
                });

                



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


       

        
          [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }



        [HttpPost]
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
                   

                };



                if (_productService.Create(entity))
                {
                    TempData.Put("message",new MessageExplanation(){
                        Title="Mehsul Elave Olundu",
                        Message="Mehsul Elave Olundu",
                        AlertType="success"
                    });

                    return RedirectToAction("ProductList");

                
                

                

                }
                 TempData.Put("message", new MessageExplanation()
                {
                    Title = "Error",
                    Message = _productService.ErrorMessage,
                    AlertType = "danger"
                });
                
                return View(model);
             



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
