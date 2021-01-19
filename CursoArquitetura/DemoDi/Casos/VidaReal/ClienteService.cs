using Microsoft.Extensions.Logging;

namespace DemoDi.Casos.VidaReal
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly ILogger _logger;

        public ClienteService(IClienteRepositorio clienteRepositorio,
                              ILogger<Cliente> logger)
        {
            _clienteRepositorio = clienteRepositorio;
            _logger = logger;
        }
        public void Adicionar(Cliente cliente)
        {
            _clienteRepositorio.Adicionar(cliente);
            _logger.LogInformation("Cliente adicionado");
        }
    }
}
