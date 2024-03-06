using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using uygulama.Entities;

namespace uygulama.Models.Context
{
    public class CafeDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NNPAIJ5; Database=KHP; Uid=sa; Pwd=789;");
        }


        public static void SeedData(CafeDbContext context)
        {
            var americano = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/americano.png");
            var cafeLatte = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cafe-latte.png");
            var cafeMocha = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cafe-mocha.png");
            var cappucino = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cappucino.png");
            var espresso = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/espresso.png");
            var espressoMacchiato = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/espresso-macchiato.png");
            var turkKahvesi = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/turk-kahvesi.png");

            context.Products.AddRange
              (
                new Product
                {
                    Name = "Espresso",
                    Image = espresso,
                    Price = 3.50m,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    ProductTypeID = 1
                },
                new Product
                {
                    Name = "Cafe Latte",
                    Image = cafeLatte,
                    Price = 3.50m,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    ProductTypeID = 1
                },
                new Product
                {
                    Name = "Cafe Mocha",
                    Image = cafeMocha,
                    Price = 3.50m,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    ProductTypeID = 1
                },
                new Product
                {
                    Name = "Cappucino",
                    Image = cappucino,
                    Price = 3.50m,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    ProductTypeID = 1
                },
                new Product
                {
                    Name = "Americano",
                    Image = americano,
                    Price = 3.50m,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    ProductTypeID = 1
                },
                new Product
                {
                    Name = "Espresso Macchiato",
                    Image = espressoMacchiato,
                    Price = 3.50m,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    ProductTypeID = 1
                },
                new Product
                {
                    Name = "Turk Kahvesi",
                    Image = turkKahvesi,
                    Price = 3.50m,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    ProductTypeID = 1
                }
              );


        }

        
    }
}
