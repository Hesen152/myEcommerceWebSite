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
using Microsoft.Extensions.Hosting;

namespace clicker.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            

               services.AddScoped<IProductRepository,EfCoreProductRepository>();
           services.AddScoped<ICategoryRepository, EfCoreCategoryRepository> ();
             services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<IProductService,ProductManager>();

        
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

           
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

                        app.UseStaticFiles();  




         
            app.UseEndpoints(endpoints =>
            {


                endpoints.MapControllerRoute(
                  name:"products",
                  pattern:"products/{category?}",
                  defaults:new {controller="Trading",action="List"}
                );
        






                endpoints.MapControllerRoute(
                  "default","{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
