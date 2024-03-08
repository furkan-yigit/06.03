namespace uygulama.Entities
{
    public class Table
    {
        public int ID { get; set; }
        public string TableName { get; set; }

        public List<Order> Orders { get; set; }

        public Table()
        {
            Orders = new List<Order>();
        }
    }
}
