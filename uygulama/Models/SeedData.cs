using Microsoft.EntityFrameworkCore;
using System;
using uygulama.Entities;
using uygulama.Models.Context;

namespace uygulama.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                CafeDbContext context = serviceScope.ServiceProvider.GetService<CafeDbContext>();

                context.Database.Migrate();

                if (!context.ProductTypes.Any())
                {
                   
                    context.ProductTypes.AddRange(
                        new ProductType() {Name = "Sicak icecekler" },
                        new ProductType() {Name = "Soguk icecekler" },
                        new ProductType() {Name = "Tatli" },
                        new ProductType() {Name = "Yemek" }
                        );
                }

                context.SaveChanges();

                if (!context.Products.Any())
                {
                    
                    context.Products.AddRange(
                        new Product(){
                            Name = "Espresso",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/espresso.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Cafe Latte",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cafe-latte.png"),
                            Price = 4.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Cafe Mocha",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cafe-mocha.png"),
                            Price = 5.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Cappucino",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cappucino.png"),
                            Price = 6.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Americano",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/americano.png"),
                            Price = 1.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Espresso Macchiato",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/espresso-macchiato.png"),
                            Price = 7.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Turk Kahvesi",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/turk-kahvesi.png"),
                            Price = 8.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1}
                       );
                }

                context.SaveChanges();


            }
            
        }
    }
}
