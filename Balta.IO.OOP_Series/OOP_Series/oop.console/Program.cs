using System;
using oop.domain;

namespace oop.consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust = new Customer("Fabio de Stefani", 1000);
            var cust2 = new Customer("Fabio de Stefani",DateTime.Now,  1000);            
            Console.WriteLine("Hello World!");
        }
    }
}
