using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using clicker.entity;

namespace clicker.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage="Kategoriya daxil edin!")]
        [StringLength(200,MinimumLength=2,ErrorMessage="2-200  herf arasi daxil etmelisiniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage="Url Daxil Edin!")]
        public string Url { get; set; }

        public List<Product> Products { get; set; }




    }
}