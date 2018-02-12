using Arquitetura.OOPo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ventilador = new Ventilador(@"Arno", 220);
            ventilador.Ligar();
            ventilador.Desligar();

            Console.ReadKey();
        }
    }
}
