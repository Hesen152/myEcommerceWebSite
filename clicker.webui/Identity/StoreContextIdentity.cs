using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace clicker.webui.Identity
{
    public class StoreContextIdentity:IdentityDbContext<User>
    {
       public   StoreContextIdentity(DbContextOptions<StoreContextIdentity> options):base(options)
        {
        }

        
    }
}