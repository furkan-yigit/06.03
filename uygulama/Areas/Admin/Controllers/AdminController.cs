using Microsoft.AspNetCore.Mvc;

namespace uygulama.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        

    }
}
