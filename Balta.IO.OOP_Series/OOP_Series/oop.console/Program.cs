using System;
using oop.domain;
using oop.domain.Entities;

namespace oop.consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust = new Customer("Fabio de Stefani", 1000);
            var cust2 = new Customer("Fabio de Stefani",DateTime.Now,  1000);            
            
            var order = new Order(cust);
            var mouse = new OrderItem("Mouse",2,10);
            order.Items.Add(mouse);
            var total = order.GetTotal();

            Console.WriteLine("Total Ped " + total);
                
        }
    }
}
