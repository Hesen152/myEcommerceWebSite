using System.ComponentModel.DataAnnotations;
namespace clicker.webui.Models
{

     
      public class RoleModel
    {
        [Required]
        public string RoleName { get; set; }
        
    }


}