namespace uygulama.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public string ImagePath { get; set; }
        public byte[] Image { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ProductTypeID { get; set; }
        public ProductType ProductType { get; set; }
    }
}
