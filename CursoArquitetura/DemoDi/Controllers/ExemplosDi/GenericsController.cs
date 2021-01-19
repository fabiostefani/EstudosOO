using DemoDi.Casos.Generics;
using Microsoft.AspNetCore.Mvc;

namespace DemoDi.Controllers.ExemplosDi
{
    public class GenericsController : Controller
    {
        private readonly IRepositorioGenerico<Cliente> _repositorioGenerico;

        public GenericsController(IRepositorioGenerico<Cliente> repositorioGenerico)
        {
            _repositorioGenerico = repositorioGenerico;
        }

        public string Index()
        {
            _repositorioGenerico.Adicionar(new Cliente());
            return "OK";

        }
    }
}
