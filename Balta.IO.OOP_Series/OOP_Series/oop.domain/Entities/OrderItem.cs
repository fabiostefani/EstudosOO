using System;
using System.Collections.Generic;
using System.Text;

namespace oop.domain.Entities
{
    public class OrderItem
    {
        public OrderItem(string product, int quantity, decimal price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetTotal()
        {
            return Price * Quantity;
        }
    }
}
