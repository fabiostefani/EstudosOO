using DemoDi.Casos.VidaReal;
using Microsoft.AspNetCore.Mvc;

namespace DemoDi.Controllers.ExemplosDi
{
    public class FromServicesController : Controller
    {

        public FromServicesController()
        {

        }
        public string Index([FromServices] IClienteService clienteService)
        {
            clienteService.Adicionar(new Cliente());
            return "Sucesso";
        }
    }
}
