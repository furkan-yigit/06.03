using System.ComponentModel.DataAnnotations;
using uygulama.Entities;

namespace uygulama.Models.ViewModels
{
    public class OrderViewModel
    {
        public Order Order { get; set; }

        public List<Table> Tables { get; set; }
        public int TableID { get; set; }

        public List<Product> Products { get; set; }

        public List<int> ProductIDs { get; set; }

        public decimal Price { get; set; }
    }
}
