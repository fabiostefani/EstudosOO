namespace DesignPatterns.Creational.FactoryMethod
{
    public class Connection
    {
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public void ExecuteCommand(string command)
        {
            Eventos.Adicionar($"Executando o comando: {command}");
        }

        public void Open()
        {
            Opened = true;
            Eventos.Adicionar("Conexão aberta");
        }

        public void Close()
        {
            Opened = false;
            Eventos.Adicionar("Conexão fechada");
        }
    }
}
