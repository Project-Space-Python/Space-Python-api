using System.Collections.Generic;
using System.linq;

namespace SpacePython.Domain.Orders
{
    public class Order {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime CreatDate { get; set; }
        public decimal TotalPrice => Items.Sum(in => int.Price);
    }
}