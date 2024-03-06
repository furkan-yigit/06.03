using Microsoft.EntityFrameworkCore;
using System;
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

        public CafeDbContext(DbContextOptions<CafeDbContext> options) : base(options)
        {
            
        }   
    }
}
