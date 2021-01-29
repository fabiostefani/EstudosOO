namespace DesignPatterns.Creational.FactoryMethod.Model
{
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }
        public override Connection Connect()
        {
            Eventos.Adicionar("Conectando ao banco Oracle...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
