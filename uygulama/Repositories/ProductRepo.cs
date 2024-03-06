using uygulama.Entities;

namespace uygulama.Repositories
{
    public class ProductRepo : IProductRepo
    {
        public IQueryable<Product> Products => new List<Product>()
        {
            new Product()
            {
                Name = "Espresso",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/espresso.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Cafe Latte",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cafe-latte.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Cafe Mocha",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cafe-mocha.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Cappucino",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/cappucino.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Americano",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/americano.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Espresso Macchiato",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/espresso-macchiato.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Turk Kahvesi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sica-icecek-resimleri/turk-kahvesi.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            }
        }.AsQueryable();

        public IQueryable<ProductType> ProductTypes => new List<ProductType>
        {
            new ProductType(){ID=1,Name="Sicak icecekler"},
            new ProductType(){ID=2,Name="Soguk icecekler"},
            new ProductType(){ID=3,Name="Tatli"},
            new ProductType(){ID=4,Name="Yemek"}
        }.AsQueryable();

        public IQueryable<Table> Tables => throw new NotImplementedException();

        public IQueryable<OrderProduct> OrderProducts => throw new NotImplementedException();

        public IQueryable<Order> Orders => throw new NotImplementedException();

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int id)
        {
            return Products.Where(x => x.ID == id).FirstOrDefault();
        }

        public bool InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
