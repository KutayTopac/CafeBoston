using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBoston.DATA.Classes
{
    public class CafeData
    {
        public int TableCount { get; set; } = 20;
        public List<Product> Products { get; set; } = new();

        public List<Order> ActiveOrders { get; set; } = new();
        public List<Order> PastOrders { get; set; } = new();
    }
}
