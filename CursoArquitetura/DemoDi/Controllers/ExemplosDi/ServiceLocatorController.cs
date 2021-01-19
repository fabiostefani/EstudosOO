using DemoDi.Casos.VidaReal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoDi.Controllers.ExemplosDi
{
    public class ServiceLocatorController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public string Index()
        {
            var clienteService = _serviceProvider.GetService<IClienteService>();
            clienteService.Adicionar(new Cliente());
            return "Sucesso";
        }
    }
}
