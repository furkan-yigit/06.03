using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using uygulama.Entities;
using uygulama.Models.Context;
using uygulama.Repositories.Abstract;

namespace uygulama.Repositories.Concrete
{
    public class OrderProductRepo : IOrderProductRepo
    {
        private readonly CafeDbContext _context;
        public OrderProductRepo(CafeDbContext context)
        {
            _context = context;
        }

        public bool AddOrderProduct(OrderProduct orderProduct)
        {
            _context.OrderProducts.Add(orderProduct);
            return SaveOrderProduct() > 0;
        }

        public bool DeleteOrderProduct(int id)
        {
            _context.OrderProducts.Remove(GetOrderProductByID(id));
            return SaveOrderProduct() > 0;
        }

        public List<OrderProduct> GetDefaultTumOrderProducts(Expression<Func<OrderProduct, bool>> exp)
        {
            return _context.OrderProducts.Where(exp).ToList();
        }

        public OrderProduct GetOrderProductByID(int id)
        {
            return _context.OrderProducts.Include(x => x.Order).Include(c=>c.Product).FirstOrDefault(z => z.ID == id);
        }

        public List<OrderProduct> GetTumOrderProducts()
        {
            return _context.OrderProducts.Include(x => x.Order).Include(c => c.Product).ToList();
        }

        public int SaveOrderProduct()
        {
            return _context.SaveChanges();
        }

        public bool UpdateOrderProduct(OrderProduct orderProduct)
        {
            _context.OrderProducts.Update(orderProduct);
            return SaveOrderProduct() > 0;
        }
    }
}
