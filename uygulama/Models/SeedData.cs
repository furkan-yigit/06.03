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
                        new ProductType() {Name = "Sicak icecekler", Type="sicak" },
                        new ProductType() {Name = "Soguk icecekler", Type = "sicak" },
                        new ProductType() {Name = "Tatli", Type = "sicak" },
                        new ProductType() {Name = "Yemek", Type = "sicak" }
                        );
                }

                context.SaveChanges();


                #region Products
                if (!context.Products.Any())
                {
                    
                    context.Products.AddRange(
                        new Product(){
                            Name = "Espresso",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/espresso.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Cafe Latte",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cafe-latte.png"),
                            Price = 4.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Cafe Mocha",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cafe-mocha.png"),
                            Price = 5.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Cappucino",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cappucino.png"),
                            Price = 6.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Americano",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/americano.png"),
                            Price = 1.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Espresso Macchiato",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/espresso-macchiato.png"),
                            Price = 7.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        new Product{
                            Name = "Turk Kahvesi",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/turk-kahvesi.png"),
                            Price = 8.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 1},
                        //***Soguklar***
                        new Product
                        {
                            Name = "Aqua Fresca",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/agua-fresca.jpg"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Buzlu Hazir Kahve",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/buzlu-hazir-kahve.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Cilek Limon",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/cilek-limon.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Cold Braw Kolali",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/cold-braw-kolali.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Dondurma Espresso",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/dondurma-espresso.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Dondurmalı Frappe",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/dondurmali-frappe.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Frappe",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/frappe.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Ice Americano",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/ice-americano.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Ice Cafe Latte",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/ice-cafe-latte.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Iced White Chocalate Mocha",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/iced-white-chocolate-mocha.jpg"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Kavun Frozen",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/kavun-frozen.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Limonata",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/limonata.webp"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Strawberry Smoothie",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/strawberry-smoothie.jpg"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        }, new Product
                        {
                            Name = "Visne Muz",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/visne-muz.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 2
                        },
                        //***TATLILAR***
                        new Product
                        {
                            Name = "Brownie",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/brownie.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 3
                        },
                        new Product
                        {
                            Name = "Cikolatali Marlenka",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/cikolatali-marlenka.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 3
                        }, new Product
                        {
                            Name = "Dondurma",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/dondurma.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 3
                        }, new Product
                        {
                            Name = "Fondu",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/fondu.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 3
                        }, new Product
                        {
                            Name = "Frambuazli Cheescake",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/frambuazli-cheescake.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 3
                        }, new Product
                        {
                            Name = "Havuclu Kek",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/havuclu-kek.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 3
                        },
                        //***YEMEKLER***
                        new Product
                        {
                            Name = "Cheese Burger",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/cheese-burger.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Chicken Mushroom Stroganoff",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/chicken-mushroom-stroganoff.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Etli Wrap",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/etli-wrap.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Firinda Tavuk Baget",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/firinda-tavuk-baget.jpg"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Food1",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/food1.jpeg"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Gevrek Simit Kahvalti",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/gevrek-simit-kahvalti.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Kahvalti Tabagi",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/kahvalti-tabagi.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Karisik Pizza",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/karisik-pizza.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Klasik Menemen",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/klasik-menemen.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Omlet",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/omlet.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Phily Steak",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/phily-steak.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Sebzeli Soslu Tavuk",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/sebzeli-soslu-tavuk.jpg"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Su Boregi",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/su-boregi.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Tavuk Kebabi",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/tavuk-kebabi.jpg"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }, new Product
                        {
                            Name = "Yumurtali Ekmek",
                            Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/yumurtali-ekmek.png"),
                            Price = 3.50m,
                            Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            ProductTypeID = 4
                        }
                       );
                }
                context.SaveChanges();               

                #endregion



                //****USERS SEEDDATA****
                if (!context.Users.Any())
                {

                    context.Users.AddRange(
                        new User() {UserName = "furkan", Password = "123456" },
                        new User() {UserName = "gorkem", Password = "123456" },
                        new User() {UserName = "omer", Password = "123456" },
                        new User() {UserName = "atalay", Password = "123456" }
                        );
                }
                context.SaveChanges();



                //****ROLES SEEDDATA****
                if (!context.Roles.Any())
                {

                    context.Roles.AddRange(
                        new Role() {UserRole = "Admin", Description = "Admin Role" },
                        new Role() {UserRole = "Employee", Description = "Employee Role" }
                        );
                }
                context.SaveChanges();



                //****USER ROLES SEEDDATA****
                if (!context.UserRoles.Any())
                {

                    context.UserRoles.AddRange(
                        new UserRole() {UserID = 1, RoleID = 2 },
                        new UserRole() {UserID = 2, RoleID = 1 },
                        new UserRole() {UserID = 3, RoleID = 2 },
                        new UserRole() {UserID = 4, RoleID = 1 }
                        );
                }
                context.SaveChanges();


            }
            
        }
    }
}
