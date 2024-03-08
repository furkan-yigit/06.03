using uygulama.Entities;

namespace uygulama.Repositories
{
    public interface IProductRepo
    {    
        Product GetByID(int id);

        bool InsertProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
        List<Product> GetAllProduct();
    }
}
