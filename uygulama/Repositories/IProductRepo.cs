using uygulama.Entities;

namespace uygulama.Repositories
{
    public interface IProductRepo
    {
        IQueryable<Product> Products { get; }
        IQueryable<ProductType> ProductTypes { get; }
        IQueryable<Table> Tables { get; }
        IQueryable<OrderProduct> OrderProducts { get; }
        IQueryable<Order> Orders { get; }


        Product GetByID(int id);

        bool InsertProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}
