using System.Collections.Generic;

namespace clicker.entity
{
    public class Category
    {

       public int CategoryId { get; set; }

        public string Name { get; set; }

       public string Url { get; set; }


       public bool  IsApproved { get; set; }

       public List<ProductCategory> ProductCategories { get; set; }

     


    }
}