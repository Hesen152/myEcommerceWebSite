using System.Collections.Generic;
using clicker.entity;

namespace clicker.webui.Models
{
    public class ProductDetailModel
    {
        public Product Products { get; set; }

        public List<Category> Categories { get; set; }
    }
}