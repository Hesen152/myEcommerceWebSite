using System.Net;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clicker.business.Abstract;
using clicker.business.Concrete;
using clicker.data.Abstract;
using clicker.data.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using clicker.webui.Identity;
using Microsoft.AspNetCore.Identity;
using clicker.webui.EmaiLService;
using Microsoft.Extensions.Configuration;

namespace clicker.webui
{
    public class Startup
    {
      private IConfiguration _configuration;
       
       public Startup(IConfiguration configuration)
       {
         _configuration=configuration;
           
       }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContext<StoreContextIdentity>(options=>
             options.UseSqlite("Data Source=clickerDb"));
             services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<StoreContextIdentity>().AddDefaultTokenProviders();
          services.Configure<IdentityOptions>(
            options=>{
              options.Password.RequireDigit=true;
              options.Password.RequireLowercase=true;
              options.Password.RequireUppercase=true;
              //Lockout
              options.Lockout.MaxFailedAccessAttempts=5;

              options.User.RequireUniqueEmail=true;
              options.SignIn.RequireConfirmedEmail=true;
              options.SignIn.RequireConfirmedPhoneNumber=false;

              

            } );

            services.ConfigureApplicationCookie(options=>
            {
              options.LoginPath="/account/login";
              options.LogoutPath="/account/logout";
              options.AccessDeniedPath="/account/accessdenied";
              options.SlidingExpiration=true;
              options.ExpireTimeSpan=TimeSpan.FromMinutes(600);
              options.Cookie=new CookieBuilder
              {
                HttpOnly=true,
                Name=".Clicker.Security.Cookie",
                SameSite=SameSiteMode.Strict

              };


            });
          
          //  });
        

            services.AddScoped<IProductRepository, EfCoreProductRepository>();
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IEmail,SmptSender>(i=>
            new SmptSender(
              _configuration["EmailSender:Host"],
              _configuration.GetValue<int>("EmailSender:Port"),
              _configuration.GetValue<bool>("EmailSender:EnableSSL"),
              _configuration["EmailSender:UserName"],
              _configuration["EmailSender:Password"]
           
             ));


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IConfiguration configuration,UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {
           app.UseHttpsRedirection();

           

           
             app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
              FileProvider=new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath="/modules"
            });
             if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }

           app.UseAuthentication();
              app.UseRouting();
              app.UseAuthorization();
            



            app.UseEndpoints(endpoints =>
            {
              
                
                //     endpoints.MapControllerRoute(
                //   name: "accountregister",
                //   pattern: "account/register",
                //   defaults: new { controller = "Account", action = "Register" }
                // );
                
              
                    endpoints.MapControllerRoute(
                  name: "adminall",
                  pattern: "admin/categories/create",
                  defaults: new { controller = "Admin", action = "CreateCategory" }
                );
                
                endpoints.MapControllerRoute(
                  name: "adminall",
                  pattern: "admin/products/create",
                  defaults: new { controller = "Admin", action = "CreateProduct" }
                );


                

                 
                    endpoints.MapControllerRoute(
                  name: "adminedit",
                  pattern: "admin/products/{id?}",
                  defaults: new { controller = "Admin", action = "EditProduct" }
                );
                      
                   endpoints.MapControllerRoute(
                  name: "search",
                  pattern: "search",
                  defaults: new { controller = "Trading", action = "searchany" }
                );

                  endpoints.MapControllerRoute(

               name:"productdetails",
               pattern:"{url}",
               defaults:new {controller="Trading",action="details"}


             );



                endpoints.MapControllerRoute(
                  name: "products",
                  pattern: "products/{category?}",
                  defaults: new { controller = "Trading", action = "List" }
                );
                   

                 endpoints.MapControllerRoute(
                  name: "admincategoryedit",
                  pattern: "admin/categories/{id?}",
                  defaults: new { controller = "Admin", action = "EditCategory" }
                );






                endpoints.MapControllerRoute(
                  "default", "{controller=Home}/{action=Index}/{id?}");
            });
                     IdentitySeed.Seed(userManager,roleManager,configuration).Wait();

        }
    }
}
