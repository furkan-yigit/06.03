namespace uygulama.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public bool IsPayment { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public int TableID { get; set; }
        public Table Table { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }

        public Order()
        {
            OrderProducts = new List<OrderProduct>();
        }
    }
}
