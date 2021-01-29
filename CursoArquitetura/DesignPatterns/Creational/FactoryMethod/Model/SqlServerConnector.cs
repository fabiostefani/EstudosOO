namespace DesignPatterns.Creational.FactoryMethod.Model
{
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }
        public override Connection Connect()
        {
            Eventos.Adicionar("Conectando ao banco SQL Server...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
