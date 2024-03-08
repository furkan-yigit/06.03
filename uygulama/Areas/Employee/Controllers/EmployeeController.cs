using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using uygulama.Models.Context;

namespace uygulama.Areas.Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly CafeDbContext _context;
      //  private readonly ITableRepo _tableRepo;
      //  private readonly IOrderRepo _orderRepo;
        

        //public EmployeeController(CafeDbContext context,ITableRepo tableRepo,IOrderRepo orderRepo)
        //{
        //    _context = context;
        //    _tableRepo = tableRepo;
        //    _orderRepo = orderRepo;
        //}



        //public IActionResult Index()
        //{
        //    return View(_tableRepo.GetTumTable());
        //}
        //public IActionResult TableDetails(int id)
        //{
        //    var tables = _tableRepo.GetTableByID(id);
        //    if (tables == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(tables);


        //}
        //[HttpGet]
        //public IActionResult TableCreate()
        //{
        //    ViewBag.TableID = new SelectList(_context.Tables, "ID", "TableName");
        //    return View();


        //}
        //[HttpPost]
        //public IActionResult TableCreate(Table table)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _tableRepo.InsertTable(table);
        //        return RedirectToAction("Index");
        //    }
        //    return View(table);
        //}
        //[HttpGet]
        //public IActionResult TableEdit(int id)
        //{
        //    var table = _tableRepo.GetTableByID(id);
        //    if (table == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewBag.TableID = new SelectList(_context.Tables, "ID", "TableName");
        //    return View(table);
        //}
        //[HttpPost]
        //public IActionResult TableEdit(Table table)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _tableRepo.UpdateTable(table);
        //        return RedirectToAction("Index");
        //    }
        //    return View(table);
        //}
        //public IActionResult TableDelete(int id)
        //{
        //    Table table = _tableRepo.GetTableByID(id);
        //    return View(table);
        //}
        //[HttpPost]
        //public IActionResult TableDelete(Table table)
        //{
        //    _tableRepo.DeleteTable(table.ID);
        //    return RedirectToAction("Index");
        //}




       

      

        

    }
}
