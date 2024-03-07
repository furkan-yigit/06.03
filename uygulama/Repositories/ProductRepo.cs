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
                ID=1,
                Name = "Espresso",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/espresso.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                ID=2,
                Name = "Cafe Latte",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cafe-latte.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                ID=3,
                Name = "Cafe Mocha",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cafe-mocha.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                ID=4,
                Name = "Cappucino",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/cappucino.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                ID=5,
                Name = "Americano",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/americano.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                ID=6,
                Name = "Espresso Macchiato",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/espresso-macchiato.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            new Product
            {
                ID=7,
                Name = "Turk Kahvesi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/sicak-icecek-resimleri/turk-kahvesi.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 1
            },
            //***Soguklar***
            new Product
            {
                ID=8,
                Name = "Aqua Fresca",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/agua-fresca.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=9,
                Name = "Buzlu Hazir Kahve",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/buzlu-hazir-kahve.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=10,
                Name = "Cilek Limon",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/cilek-limon.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=11,
                Name = "Cold Braw Kolali",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/cold-braw-kolali.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=12,
                Name = "Dondurma Espresso",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/dondurma-espresso.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=13,
                Name = "Dondurmalı Frappe",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/dondurmali-frappe.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=14,
                Name = "Frappe",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/frappe.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=15,
                Name = "Ice Americano",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/ice-americano.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=16,
                Name = "Ice Cafe Latte",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/ice-cafe-latte.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=17,
                Name = "Iced White Chocalate Mocha",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/iced-white-chocolate-mocha.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=18,
                Name = "Kavun Frozen",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/kavun-frozen.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=19,
                Name = "Limonata",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/limonata.webp"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=20,
                Name = "Strawberry Smoothie",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/strawberry-smoothie.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },new Product
            {
                ID=21,
                Name = "Visne Muz",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/soguk-icecek-resimleri/visne-muz.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 2
            },
            //***TATLILAR***
            new Product
            {
                ID=22,
                Name = "Brownie",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/brownie.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },
            new Product
            {
                ID=23,
                Name = "Cikolatali Marlenka",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/cikolatali-marlenka.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },new Product
            {
                ID=24,
                Name = "Dondurma",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/dondurma.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },new Product
            {
                ID=25,
                Name = "Fondu",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/fondu.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },new Product
            {
                ID=26,
                Name = "Frambuazli Cheescake",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/frambuazli-cheescake.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },new Product
            {
                ID=27,
                Name = "Havuclu Kek",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/tatli-resimleri/havuclu-kek.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 3
            },
            //***YEMEKLER***
            new Product
            {
                ID=28,
                Name = "Cheese Burger",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/cheese-burger.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=29,
                Name = "Chicken Mushroom Stroganoff",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/chicken-mushroom-stroganoff.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=30,
                Name = "Etli Wrap",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/etli-wrap.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=31,
                Name = "Firinda Tavuk Baget",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/firinda-tavuk-baget.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=32,
                Name = "Food1",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/food1.jpeg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=33,
                Name = "Gevrek Simit Kahvalti",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/gevrek-simit-kahvalti.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=34,
                Name = "Kahvalti Tabagi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/kahvalti-tabagi.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=35,
                Name = "Karisik Pizza",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/karisik-pizza.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=36,
                Name = "Klasik Menemen",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/klasik-menemen.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=37,
                Name = "Omlet",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/omlet.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=38,
                Name = "Phily Steak",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/phily-steak.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=39,
                Name = "Sebzeli Soslu Tavuk",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/sebzeli-soslu-tavuk.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=40,
                Name = "Su Boregi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/su-boregi.png"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=41,
                Name = "Tavuk Kebabi",
                Image = System.IO.File.ReadAllBytes("wwwroot/Images/yemek-resimleri/tavuk-kebabi.jpg"),
                Price = 3.50m,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ProductTypeID = 4
            },new Product
            {
                ID=42,
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

        public IQueryable<User> Users => new List<User>
        {
            new User(){ID=1,UserName="furkan",Password="123456"},
            new User(){ID=2,UserName="gorkem",Password="123456"},
            new User(){ID=3,UserName="omer",Password="123456"},
            new User(){ID=4,UserName="atalay",Password="123456"},
        }.AsQueryable();

        public IQueryable<Role> Roles => new List<Role>
        {
            new Role(){ID=1,UserRole="Admin",Description="Admin Role"},
            new Role(){ID=2,UserRole="Employee",Description="Employee Role"}
        }.AsQueryable();

        public IQueryable<UserRole> UserRoles => new List<UserRole>
        {
            new UserRole(){ID=1,UserID=1,RoleID=2},
            new UserRole(){ID=2,UserID=2,RoleID=1},
            new UserRole(){ID=3,UserID=3,RoleID=2},
            new UserRole(){ID=4,UserID=4,RoleID=1}
        }.AsQueryable();

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
