using System.Linq.Expressions;
using uygulama.Entities;

namespace uygulama.Repositories.Abstract
{
    public interface IOrderRepo
    {
        Order GetOrderByID(int id);
        List<Order> GetTumOrders();
        List<Order> GetDefaultTumOrders(Expression<Func<Order, bool>> exp); // Metoda LINQ göndereceğimiz için paramete olara expression aldık
        bool AddOrder(Order order);
        bool UpdateOrder(Order order);
        bool DeleteOrder(int id);
        int SaveOrder(); //EF Core savechanges() metodu geriye int değer döndürür.
    }
}
