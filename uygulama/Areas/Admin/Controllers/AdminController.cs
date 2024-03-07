using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using uygulama.Models.Context;

namespace uygulama.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly CafeDbContext _context;

        public AdminController(CafeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        public IActionResult Products()
        {
            return View(_context.Products);
        }



    }
}
