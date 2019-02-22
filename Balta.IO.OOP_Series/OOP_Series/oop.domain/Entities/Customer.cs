using System;

namespace oop.domain
{
    public class Customer
    {
        public Customer(string name, DateTime birthdate, decimal salery)
        {
            Name = name;
            Birthdate = birthdate;
            Salery = salery;
        }

        public Customer(string name, decimal salery)
        {
            Name = name;
            Salery = salery;
        }

        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public decimal Salery { get; set; }
    }
}