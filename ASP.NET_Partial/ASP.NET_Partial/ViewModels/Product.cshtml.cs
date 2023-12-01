using ASP.NET_Partial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Partial.ViewModels
{
    public class ProductModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = new List<Product>()
            {
                new Product{Name="Men's Shirt", Description="Men's Shirt", Price = 75, ImgPath="p1.png"},
                new Product{Name="Men's Shirt", Description="Add To Cart", Price = 80, ImgPath="p2.png"},
                new Product{Name="Women's Dress", Description="Add To Cart", Price = 68, ImgPath="p3.png"},
                new Product{Name="Women's Dress", Description="Add To Cart", Price = 70, ImgPath="p4.png"},
                new Product{Name="Women's Dress", Description="Add To Cart", Price = 75, ImgPath="p5.png"},
                new Product{Name="Women's Dress", Description="Add To Cart", Price = 58, ImgPath="p6.png"},
                new Product{Name="Women's Dress", Description="Add To Cart", Price = 80, ImgPath="p7.png"},
                new Product{Name="Men's Shirt", Description="Add To Cart", Price = 65, ImgPath="p8.png"},
                new Product{Name="Men's Shirt", Description="Add To Cart", Price = 65, ImgPath="p9png"},
                new Product{Name="Men's Shirt", Description="Add To Cart", Price = 65, ImgPath="p10.png"},
                new Product{Name="Men's Shirt", Description="Add To Cart", Price = 65, ImgPath="p11.png"},
                new Product{Name="Women's Dress", Description="Add To Cart", Price = 65, ImgPath="p12.png"},
            };
        }
    }
}
