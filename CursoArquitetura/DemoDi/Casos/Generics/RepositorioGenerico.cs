using Microsoft.Extensions.Logging;

namespace DemoDi.Casos.Generics
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        private readonly ILogger<T> _logger;

        public RepositorioGenerico(ILogger<T> logger)
        {
            _logger = logger;
        }
        public void Adicionar(T obj)
        {
            _logger.LogInformation("Cliente adicionado no generics");
        }
    }
}
