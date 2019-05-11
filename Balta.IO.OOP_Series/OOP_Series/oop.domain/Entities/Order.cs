using System;
using System.Collections.Generic;
using System.Text;

namespace oop.domain.Entities
{
    public class Order
    {
        public Order(Customer customer)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
            Date = new DateTime();
            Customer = customer;
            Items = new List<OrderItem>();
        }

        public string Number { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public IList<OrderItem> Items { get; set; }

        public decimal GetTotal()
        {
            var total = 0m;
            foreach (var item in Items)
            {
                total += item.GetTotal();
            }
            return total;
        }
    }
}
