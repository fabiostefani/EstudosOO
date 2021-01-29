using DesignPatterns.Creational.FactoryMethod.Model;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class DbOracleFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }
    }
}
