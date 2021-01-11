namespace SOLID._5___DIP.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
            {
                return "Dados inválidos";
            }

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com.br", cliente.Email, "Bem vindo", "corpo");

            return "Cliente cadastrado com sucesso.";
        }
    }
}
