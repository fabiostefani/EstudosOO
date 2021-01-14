using DemoDi.Casos.VidaReal;
using Microsoft.AspNetCore.Mvc;

namespace DemoDi.Controllers.ExemplosDi
{
    public class VidaRealController : Controller
    {
        private readonly IClienteService _clienteService;

        public VidaRealController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        public IActionResult Index()
        {
            _clienteService.Adicionar(new Cliente());
            //return View("Sucesso");
            return View();
        }
    }
}
