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
            // Veritabanı bağlantı bilgilerini buraya ekleyin
            optionsBuilder.UseSqlServer("YourConnectionString");
        }


        public static void SeedData(CafeDbContext context)
        {
            var americano = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/americano.png");
        }
    }
}
