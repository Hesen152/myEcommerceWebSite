using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace clicker.webui.Models
{
    public class PasswordResetModel
    {

          [Required]
        public string Token { get; set; }

          [Required]

        public string Email { get; set; }
       
         [Required]

        public string Password { get; set; }

       
        
    }
}