using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Structural.Adapter;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    public class AdapterController : Controller
    {
        private readonly ILogger _logger;
        private readonly ILogNetMaster _logNetMaster;

        public AdapterController(ILogger logger,
                                 ILogNetMaster logNetMaster)
        {
            _logger = logger;
            _logNetMaster = logNetMaster;
        }
        public string Index()
        {
            Eventos.LimparDados();
            var pagamentoLogPadrao = new TransacaoService(_logger);
            pagamentoLogPadrao.RealizarTransacao();

            var pagamentoLogCustom = new TransacaoService(new LogAdapter(_logNetMaster));
            pagamentoLogCustom.RealizarTransacao();
            return Eventos.Imprimir();
        }
    }
}
