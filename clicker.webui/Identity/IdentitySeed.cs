using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace clicker.webui.Identity
{
    public static class IdentitySeed
    {

        public static async Task Seed(UserManager<User> userManager,RoleManager<IdentityRole> roleManager,IConfiguration configuration  )
      {

          var username=configuration["Data:Adminuser:username"];
           var email=configuration["Data:Adminuser:email"];
           var password=configuration["Data:Adminuser:password"];
           var role=configuration["Data:Adminuser:username"];

           if (await userManager.FindByNameAsync(username)==null)
           {
               await roleManager.CreateAsync(new IdentityRole(role));
               var user=new User()
               {
                   UserName=username,
                   Email=email,
                   FirstName="admin",
                   LastName="admin",
                   EmailConfirmed=true
               };
               var result=await userManager.CreateAsync(user,password);
               if (result.Succeeded)
               {
                   await userManager.AddToRoleAsync(user,role);
                   
               }

           }



      }  
        
    }
}