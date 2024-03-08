using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using uygulama.Entities;
using uygulama.Models.Context;
using uygulama.Repositories.Abstract;

namespace uygulama.Repositories.Concrete
{
    public class OrderRepo : IOrderRepo
    {
        private readonly CafeDbContext _context;
        public OrderRepo(CafeDbContext context)
        {
            _context = context;
        }

        public bool AddOrder(Order order)
        {
            _context.Orders.Add(order);
            return SaveOrder() > 0;
        }

        public bool DeleteOrder(int id)
        {
            _context.Orders.Remove(GetOrderByID(id));
            return SaveOrder() > 0;
        }

        public List<Order> GetDefaultTumOrders(Expression<Func<Order, bool>> exp)
        {
            return _context.Orders.Where(exp).ToList();
        }

        public Order GetOrderByID(int id)
        {
            //return _context.Orders.Find(id); // tek tablodaki ilgili veriyi döndürür.
            return _context.Orders.Include(x => x.Table).FirstOrDefault(z => z.ID == id); // ilgili öğrenci ve okulu bilgisini döndürü SQL JOIN metodu gibi
        }

        public IQueryable<Product> GetProducts()
        {
            return _context.Products;
        }

        public IQueryable<Table> GetTables()
        {
            return _context.Tables;
        }

        public List<Order> GetTumOrders()
        {
            return _context.Orders.Include(x => x.Table).ToList();
        }

        public int SaveOrder()
        {
            return _context.SaveChanges();
        }

        public bool UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            return SaveOrder() > 0;
        }
    }
}
