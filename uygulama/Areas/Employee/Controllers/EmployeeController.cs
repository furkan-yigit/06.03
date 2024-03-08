using Microsoft.AspNetCore.Mvc;
using uygulama.Models.Context;

namespace uygulama.Areas.Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly CafeDbContext _context;

        public EmployeeController(CafeDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            return View(_context.Tables);
        }
    }
}
