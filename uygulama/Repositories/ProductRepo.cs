using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using uygulama.Entities;
using uygulama.Models.Context;

namespace uygulama.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly CafeDbContext _context;
        public ProductRepo(CafeDbContext context)
        {
            _context=context;
        }      


        public bool DeleteProduct(int id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return false;
            }
            _context.Entry(product).State = EntityState.Deleted;
            //_context.Products.Remove(product);
            return _context.SaveChanges() > 0;
        }

        public List<Product> GetAllProduct()
        {
            return _context.Products.ToList();
        }

        public Product GetByID(int id)
        {
            return _context.Products.Where(x => x.ID == id).FirstOrDefault();
        }

        public bool InsertProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Added;
            return _context.SaveChanges() > 0;
        }

        public bool UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
