using System.ComponentModel.DataAnnotations;

namespace clicker.webui.Models
{
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]

        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }

        
        public string Email { get; set; }


    }
}