using Microsoft.EntityFrameworkCore;
using uygulama.Models;
using uygulama.Models.Context;
using uygulama.Repositories;

namespace uygulama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<CafeDbContext>(options => options.UseSqlServer(@"Server= DESKTOP-JI3UVS4; Database=CoffeeWebSite; Uid=sa; Pwd=123;"));

            builder.Services.AddTransient<IProductRepo, ProductRepo>();

            
            var app = builder.Build();            

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            SeedData.Seed(app);

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}