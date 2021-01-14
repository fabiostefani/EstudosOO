namespace DemoDi.Casos.VidaReal
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public void Adicionar(Cliente cliente)
        {
            _clienteRepositorio.Adicionar(cliente);
        }
    }
}
