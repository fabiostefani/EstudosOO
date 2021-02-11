using DesignPatterns.Behavioral;
using DesignPatterns.Creational.FactoryMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    public class CommandController : Controller
    {

        public CommandController()
        {

        }
        public string Index()
        {
            Eventos.LimparDados();
            var user = new Usuario();

            user.Adicionar('+', 100);
            //Console.ReadKey();
            user.Adicionar('-', 50);
            //Console.ReadKey();
            user.Adicionar('*', 10);
            //Console.ReadKey();
            user.Adicionar('/', 2);
            //Console.ReadKey();

            user.Desfazer(4);
            //Console.ReadKey();

            user.Retornar(3);
            return Eventos.Imprimir();
        }
    }
}
