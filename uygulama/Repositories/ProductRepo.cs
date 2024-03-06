using uygulama.Entities;

namespace uygulama.Repositories
{
    public class ProductRepo : IProductRepo
    {

        #region SeedData

        
        public IQueryable<Product> Products => new List<Product>()
        {
            //***Sicaklar***
            new Product()
            {
                Name = "Espresso",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/espresso.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Cafe Latte",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cafe-latte.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Cafe Mocha",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cafe-mocha.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Cappucino",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cappucino.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Americano",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/americano.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Espresso Macchiato",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/espresso-macchiato.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                Name = "Turk Kahvesi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/turk-kahvesi.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            //***Soguklar***
            new Product
            {
                Name = "Aqua Fresca",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/agua-fresca.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Buzlu Hazir Kahve",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/buzlu-hazir-kahve.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Cilek Limon",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/cilek-limon.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Cold Braw Kolali",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/cold-braw-kolali.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Dondurma Espresso",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/dondurma-espresso.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Dondurmali Frappe",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/dondurmali-frappe.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Frappe",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/frappe.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Ice Americano",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/ice-americano.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Ice Cafe Latte",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/ice-cafe-latte.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Iced White Chocalate Mocha",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/iced-white-chocolate-mocha.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Kavun Frozen",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/kavun-frozen.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Limonata",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/limonata.webp"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Strawberry Smoothie",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/strawberry-smoothie.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                Name = "Visne Muz",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/visne-muz.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },
            //***TATLILAR***
            new Product
            {
                Name = "Brownie",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/brownie.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },
            new Product
            {
                Name = "Cikolatali Marlenka",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/cikolatali-marlenka.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },new Product
            {
                Name = "Dondurma",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/dondurma.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },new Product
            {
                Name = "Fondu",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/fondu.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },new Product
            {
                Name = "Frambuazli Cheescake",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/frambuazli-cheescake.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },new Product
            {
                Name = "Havuclu Kek",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/havuclu-kek.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },
            //***YEMEKLER***
            new Product
            {
                Name = "Cheese Burger",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/cheese-burger.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Chicken Mushroom Stroganoff",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/chicken-mushroom-stroganoff.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Etli Wrap",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/etli-wrap.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Firinda Tavuk Baget",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/firinda-tavuk-baget.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Food1",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/food1.jpeg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Gevrek Simit Kahvalti",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/gevrek-simit-kahvalti.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Kahvalti Tabagi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/kahvalti-tabagi.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Karisik Pizza",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/karisik-pizza.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Klasik Menemen",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/klasik-menemen.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Omlet",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/omlet.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Phily Steak",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/phily-steak.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Sebzeli Soslu Tavuk",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/sebzeli-soslu-tavuk.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Su Boregi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/su-boregi.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Tavuk Kebabi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/tavuk-kebabi.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                Name = "Yumurtali Ekmek",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/yumurtali-ekmek.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },

        }.AsQueryable();

        #endregion

        public IQueryable<ProductType> ProductTypes => new List<ProductType>
        {
            new ProductType(){ID=1,Name="Sicak icecekler", Type="sicak"},
            new ProductType(){ID=2,Name="Soguk icecekler", Type="sicak"},
            new ProductType(){ID=3,Name="Tatli", Type="sicak"},
            new ProductType(){ID=4,Name="Yemek", Type="sicak"}
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
