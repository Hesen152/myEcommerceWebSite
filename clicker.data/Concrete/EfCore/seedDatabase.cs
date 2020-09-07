using System.Linq;
using System.Net.Mime;
using clicker.entity;
using Microsoft.EntityFrameworkCore;

namespace clicker.data.Concrete.EfCore
{
    public static class SeedDatabase
    {


        public static void Seed()
        {
            var context = new ClickerContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);

                }

            }

            context.SaveChanges();



        }

        private static Category[] Categories ={
            new Category(){Name="Kisi Geyimleri",Url="kisigeyim"},
            new Category(){Name="Qadin Geyimleri",Url="qadingeyim"},
            new Category(){Name="Telefon Aksesuarlari",Url="qedebi"},
             new Category(){Name="Komputer&Ofis",Url="komputerofis"},
             new Category(){Name="Istehlakci Elektronika",Url="elektornika"},
            new Category(){Name="Zinet  Esyalari",Url="zinet"},
            new Category(){Name="Canta&Ayaqqabi",Url="cantayaqqabi"},
            new Category(){Name="Hamisini Gor!",Url="hamisi"},
           };



        private static Product[] Products =
          {
      new Product(){Name="Adidas",Url="adidas",Price=2000,ImageUrl="1.jpg",Description="mohtesem paltar",IsApproved=true},
      new Product(){Name="Twist ",Url="twist",Price=8000,ImageUrl="2.jpg",Description="onde geden",IsApproved=true},
      new Product(){Name="BEYMEN ",Url="beymen",Price=1500,ImageUrl="3.jpg",Description="cox ela ",IsApproved=true},
      new Product(){Name="SETRE",Url="setre",Price=3900,ImageUrl="4.jpg",Description="monicanin favariti",IsApproved=false},
      new Product(){Name="HUMMEL",Url="hummel",Price=7699,ImageUrl="5.jpg",Description="yaxsidir",IsApproved=true},
      new Product(){Name="ALDO",Url="puskin",Price=2000,ImageUrl="6.jpg",Description="soz yox",IsApproved=true},
      new Product(){Name="LACOSATE ",Url="lacosate",Price=1600,ImageUrl="7.jpg",Description="kapitalizm",IsApproved=true},
      new Product(){Name="EMPIRYOLE ",Url="empiryole",Price=1500,ImageUrl="8.jpg",Description="dehsetizm ",IsApproved=true},
      new Product(){Name="BELUCCI",Url="belucci",Price=2000,ImageUrl="9.jpg",Description="superdir",IsApproved=true},
      new Product(){Name="IGNORATE",Url="ignorate",Price=6500,ImageUrl="10.jpg",Description="entiqedir",IsApproved=true},
      new Product(){Name="NETWORK",Url="network",Price=2000,ImageUrl="11.jpg",Description="mukemmel",IsApproved=true},
      new Product(){Name="BRAUN Ayaqqabi",Url="braun",Price=7900,ImageUrl="12.jpg",Description="elaa",IsApproved=true},
      new Product(){Name="SSD&&DDV Kalonka ",Url="mavi",Price=1500,ImageUrl="13.jpg",Description="elaaaa ",IsApproved=true},
      new Product(){Name="KOTON",Url="koton",Price=1400,ImageUrl="14.jpg",Description="qesenggg",IsApproved=false},
      new Product(){Name="KARACA",Url="karaca",Price=6500,ImageUrl="15.jpg",Description="gozelll",IsApproved=true},
      new Product(){Name="COLUMBIA",Url="coulmbia",Price=2000,ImageUrl="16.jpg",Description="ureyim gedir",IsApproved=true},
      new Product(){Name="CALVIN KLEIN",Url="calvinklein",Price=8000,ImageUrl="17.jpg",Description="mohtesemmm",IsApproved=true},
      new Product(){Name="CAMPER",Url="camper",Price=2344,ImageUrl="18.jpg",Description="sevimli ",IsApproved=true},
      new Product(){Name="ARCELIK",Url="arcelik",Price=3455,ImageUrl="19.jpg",Description="delikimi",IsApproved=false},
      new Product(){Name="RAMSEY",Url="ramsey",Price=3432,ImageUrl="20.jpg",Description="sozssuz",IsApproved=true}
      };


        private static ProductCategory[] ProductCategories ={

   new ProductCategory(){Product=Products[0],Category=Categories[3]},
      new ProductCategory(){Product=Products[1],Category=Categories[0]},
    new ProductCategory(){Product=Products[1],Category=Categories[3]},
    new ProductCategory(){Product=Products[4],Category=Categories[2]},
    new ProductCategory(){Product=Products[4],Category=Categories[14]},
    new ProductCategory(){Product=Products[1],Category=Categories[2]},
    new ProductCategory(){Product=Products[5],Category=Categories[12]},
      new ProductCategory(){Product=Products[3],Category=Categories[15]},
    new ProductCategory(){Product=Products[3],Category=Categories[7]},
    new ProductCategory(){Product=Products[4],Category=Categories[2]},
    new ProductCategory(){Product=Products[7],Category=Categories[16]},
    new ProductCategory(){Product=Products[6],Category=Categories[19]},
  new ProductCategory(){Product=Products[5],Category=Categories[12]},
    new ProductCategory(){Product=Products[2],Category=Categories[11]},
    new ProductCategory(){Product=Products[1],Category=Categories[18]},
    new ProductCategory(){Product=Products[4],Category=Categories[16]},
   };


    }



}