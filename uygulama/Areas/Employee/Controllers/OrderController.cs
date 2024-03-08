using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uygulama.Entities;

namespace uygulama.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class OrderController : Controller
    {
        //private readonly IOrderRepository _orderRepository;

        //public OrderController(IOrderRepository orderRepository)
        //{
        //    _orderRepository=orderRepository;
        //}



        
        //public ActionResult Index()
        //{
        //    var order = _orderRepository.GetTumOrderlar();
        //    return View(order);
        //}

        
        //public ActionResult Details(int id)
        //{
        //    var order = _orderRepository.GetOrderByID(id);
        //    return View(order);
        //}

        
        //public ActionResult Create()
        //{
        //    var orderViewModel = new OrderViewModel
        //    {
        //        Tables = GetTablesList(),
        //        Products = GetProductList()
        //    };

        //    return View(orderViewModel);
        //}

        
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(OrderViewModel orderViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
                
        //        var order = new Order
        //        {
        //            IsPayment = false,
        //            Price = orderViewModel.Price,
        //            OrderDate = DateTime.Now,
        //            TableID = orderViewModel.TableID
        //        };

        //        order.OrderProducts = new List<OrderProduct>();
        //        foreach (var item in orderViewModel.ProductIDs)
        //        {
        //            var orderProduct = new OrderProduct
        //            {
        //                Quantity = 1,
        //                UnitPrice = _orderRepository.GetProductByID(item).Price,
        //                ProductID = item
        //            };
        //            order.OrderProducts.Add(orderProduct);
        //        }

        //        _orderRepository.AddOrder(order);
        //        return RedirectToAction("Index");
        //    }

        //    orderViewModel.Tables = GetTableList(); 
        //    orderViewModel.Products = GetProductList(); 
        //    return View(orderViewModel);
        //}

       
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(int id)
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
