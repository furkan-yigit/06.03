using System.Linq.Expressions;
using uygulama.Entities;

namespace uygulama.Repositories.Abstract
{
    public interface IOrderProductRepo
    {
        OrderProduct GetOrderProductByID(int id);
        List<OrderProduct> GetTumOrderProducts();
        List<OrderProduct> GetDefaultTumOrderProducts(Expression<Func<OrderProduct, bool>> exp); // Metoda LINQ göndereceğimiz için paramete olara expression aldık
        bool AddOrderProduct(OrderProduct orderProduct);
        bool UpdateOrderProduct(OrderProduct orderProduct);
        bool DeleteOrderProduct(int id);
        int SaveOrderProduct();
    }
}
