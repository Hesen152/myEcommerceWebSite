using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using clicker.entity;

namespace clicker.webui.Models
{
    public class ProductModel
    {

        

        public int ProductId { get; set; }
         [Required]
        public string Name { get; set; }

        [Required(ErrorMessage="ImageUrl Mecburidir!")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage="Url Mecburidir!")]
        
        public string Url { get; set; }

        [Required]
        [Range(2,10000,ErrorMessage="2-10000 arasi girmelisiniz")]
        public decimal? Price { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 4, ErrorMessage = "Aciqlama qismi 4-300 araliqinda olmalidir ")]
        public string Description { get; set; }

        public bool IsApproved { get; set; }

        public bool IsHome { get; set; }

        public List<Category> SelectedCategories { get; set; }


    }
}