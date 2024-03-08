using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uygulama.Entities;
using uygulama.Models.ViewModels;
using uygulama.Repositories.Abstract;

namespace uygulama.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;

        public OrderController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }




        public ActionResult Index()
        {
            var order = _orderRepo.GetTumOrders();
            return View(order);
        }


        public ActionResult Details(int id)
        {
            var order = _orderRepo.GetOrderByID(id);
            return View(order);
        }


        public ActionResult Create()
        {
            var orderViewModel = new OrderViewModel
            {
                Tables = _orderRepo.GetTables().ToList(),
                Products = _orderRepo.GetProducts().ToList()
            };

            return View(orderViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel orderViewModel)
        {
            if (ModelState.IsValid)
            {

                var order = new Order
                {
                    IsPayment = false,
                    Price = orderViewModel.Price,
                    OrderDate = DateTime.Now,
                    TableID = orderViewModel.TableID
                };

                order.OrderProducts = new List<OrderProduct>();
                foreach (var item in orderViewModel.ProductIDs)
                {
                    var orderProduct = new OrderProduct
                    {
                        Quantity = 1,
                        UnitPrice = _orderRepo.GetOrderByID(item).Price,
                        ProductID = item
                    };
                    order.OrderProducts.Add(orderProduct);
                }

                _orderRepo.AddOrder(order);
                return RedirectToAction("Index");
            }

            orderViewModel.Tables = _orderRepo.GetTables().ToList();
            orderViewModel.Products = _orderRepo.GetProducts().ToList();
            return View(orderViewModel);
        }


        public ActionResult Edit(int id)
        {
            var orderViewModel = new OrderViewModel
            {
                Order = _orderRepo.GetOrderByID(id),
                Tables = _orderRepo.GetTables().ToList(),
                Products = _orderRepo.GetProducts().ToList()
            };

            return View(orderViewModel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrderViewModel orderViewModel)
        {
            if (ModelState.IsValid)
            {
                var order = _orderRepo.GetOrderByID(id);
                order.Price = orderViewModel.Price;

                order.OrderProducts.Clear();
                foreach (var item in orderViewModel.ProductIDs)
                {
                    var orderProduct = new OrderProduct
                    {
                        Quantity = 1,
                        UnitPrice = _orderRepo.GetOrderByID(item).Price,
                        ProductID = item
                    };
                    order.OrderProducts.Add(orderProduct);
                }

                _orderRepo.UpdateOrder(order);
                return RedirectToAction("Index");
            }

            orderViewModel.Tables= _orderRepo.GetTables().ToList();
            orderViewModel.Products= _orderRepo.GetProducts().ToList();
            return View(orderViewModel);
        }

        
        public ActionResult Delete(int id)
        {
            _orderRepo.DeleteOrder(id);
            return RedirectToAction("Index");
        }
        
        
    }
}
