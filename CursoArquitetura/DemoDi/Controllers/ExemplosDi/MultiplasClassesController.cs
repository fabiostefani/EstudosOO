using DemoDi.Casos.MultiplasClasses;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoDi.Controllers.ExemplosDi
{
    public class MultiplasClassesController : Controller
    {
        private readonly Func<string, IServico> _serviceAcessor;

        public MultiplasClassesController(Func<string, IServico> serviceAcessor)
        {
            _serviceAcessor = serviceAcessor;
        }
        public string Index()
        {
            return _serviceAcessor("A").Retorno();
        }

        public string ChamaB()
        {
            return _serviceAcessor("B").Retorno();
        }
    }
}
