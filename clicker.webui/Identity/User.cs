using Microsoft.AspNetCore.Identity;

namespace clicker.webui.Identity
{
    public class User:IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
    }
}