using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
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
        public HomeController(ILogger<HomeController> logger, IProductRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }
        
        public IActionResult Index()
        {
            return View(_repo.Products);
        }

        


        public IActionResult UrunleriGoster(int productTypeId)
        {
            var arananProduct = _repo.Products.Where(p => p.ProductTypeID == productTypeId);
            string turu = _repo.ProductTypes.FirstOrDefault(x => x.ID == productTypeId).Name;
            ViewBag.Turu = turu;
            return View(arananProduct);
        }

        public IActionResult DetayGoster(int productId)
        {
            var arananProduct = _repo.Products.Where(p => p.ID == productId);
            return View(arananProduct);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
