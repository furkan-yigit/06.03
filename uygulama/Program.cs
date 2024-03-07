using Microsoft.AspNetCore.Authentication.Cookies;
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
            builder.Services.AddDbContext<CafeDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-NNPAIJ5; Database=CAFEWebSite; Uid=sa; Pwd=789;"));
            //builder.Services.AddDbContext<CafeDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-JI3UVS4; Database= CAFEWebSite; Uid=sa; Pwd=123;"));
            //builder.Services.AddDbContext<CafeDbContext>(options => options.UseSqlServer(@"Server=G™RKEMH; Database= CAFEWebSite; Uid=sa; Pwd=123;"));

            builder.Services.AddTransient<IProductRepo, ProductRepo>();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {

                options.LoginPath = "/Home/Login";// Login islemleri icin hangi sayfa kullanilacak.
                //options.LogoutPath = "/Admin/Admin/Logout";
                options.AccessDeniedPath = "/Home/Login";// Yetkisiz kisilerin yonlendirilecegi sayfa
                options.ExpireTimeSpan = System.TimeSpan.FromMinutes(60);// Cookie ne zaman bitecek?
                options.Events.OnRedirectToLogin = context =>
                {
                    
                    return Task.CompletedTask;
                };// login islemi gerceklestirildikten sonra htttp context ile gelen bilgiye gore hangi sayfadan login e yonlendirildiyse geri o sayfaya donsun
            });
           
            
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

            app.UseAuthentication();
            app.UseAuthorization();
            SeedData.Seed(app);

            //AREA ADMIN
            app.MapAreaControllerRoute(
                name: "AdminArea",
                areaName: "Admin",
                pattern: "Admin/{controller=Admin}/{action=Index}/{id?}"
                );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}