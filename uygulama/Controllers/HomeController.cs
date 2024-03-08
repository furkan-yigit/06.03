using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using uygulama.Entities;
using uygulama.Models;
using uygulama.Models.Context;
using uygulama.Repositories;

namespace uygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepo _repo;
        private readonly CafeDbContext _context;
        public HomeController(ILogger<HomeController> logger, IProductRepo repo, CafeDbContext context)
        {
            _logger = logger;
            _repo = repo;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAllProduct());
        }

        [HttpGet]
        public IActionResult Login(string returnURL) // Login sayfasina nereden geldigimizi tutmak icin parametre aldik.
        {
            ViewBag.ReturnURL = returnURL; // Login sayfasina ViewBag ile geri donecegimiz sayfa bilgisini aktarabiliriz.
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string returnURL, string UserName, string Password)
        {
            var girisYapanKullanici = _context.UserRoles.Where(x => x.User.UserName == UserName && x.User.Password == Password).Select(x=>new { 
                
                Id = x.User.ID,
                UserName = x.User.UserName,
                Password=x.User.Password,
                Role= x.Role.UserRole
            }).FirstOrDefault();

            if (girisYapanKullanici != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim("ID", girisYapanKullanici.Id.ToString()),
                    new Claim(ClaimTypes.Name, girisYapanKullanici.UserName),
                    new Claim(ClaimTypes.Surname, girisYapanKullanici.Password),
                    new Claim(ClaimTypes.Role, girisYapanKullanici.Role),
                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.Now.AddMinutes(10),
                };

                await HttpContext.SignInAsync(principal, props);

                if (girisYapanKullanici.Role == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }

                return Redirect(returnURL);
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(); 
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ErisimEngellendi()
        {
            return View();//Authentication dan gecemeyen kullanicilari Authorize etme (yetkilendirme) ve bu sayfayi goster.
        }



        public IActionResult UrunleriGoster(int productTypeId)
        {
            var arananProduct = _repo.GetAllProduct().Where(p => p.ProductTypeID == productTypeId);
            string turu = _context.ProductTypes.FirstOrDefault(x => x.ID == productTypeId).Name;
            ViewBag.Turu = turu;
            return View(arananProduct);
        }

        public IActionResult DetayGoster(int productId)
        {
            var arananProduct = _repo.GetAllProduct().FirstOrDefault(p => p.ID == productId);
            return View(arananProduct);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
