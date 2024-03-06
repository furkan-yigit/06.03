using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using uygulama.Models;
using uygulama.Models.Context;

namespace uygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CafeDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger, CafeDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index(string productType = null)
        {
            var products = _dbContext.Products
            .Include(p => p.ProductType)
            .Where(p => productType == null || p.ProductType.Type == productType)
            .ToList();

            var carouselImages = _dbContext.Products
                .Select(pt => pt.Image)
                .ToList();

            ViewData["Products"] = products;
            ViewData["CarouselImages"] = carouselImages;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
