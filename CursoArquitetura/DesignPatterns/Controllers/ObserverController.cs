using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Creational.FactoryMethod;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DesignPatterns.Controllers
{
    public class ObserverController : Controller
    {
        public string Index()
        {
            Eventos.LimparDados();
            var joao = new Observador("João");
            var eduardo = new Observador("Eduardo");
            var bill = new Observador("Bill");

            var amazon = new PapelBovespa("Amazon", NextDecimal());
            var microsoft = new PapelBovespa("Microsoft", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(eduardo);

            microsoft.Subscribe(eduardo);
            microsoft.Subscribe(bill);

            Eventos.Adicionar("");
            Eventos.Adicionar("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Valor = NextDecimal();
                microsoft.Valor = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(eduardo);
                }
            }
            return Eventos.Imprimir();
        }

        private static decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
            return r / (decimal)100000.00;
        }
    }
}
