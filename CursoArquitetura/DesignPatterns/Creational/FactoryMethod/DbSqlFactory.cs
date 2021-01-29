using DesignPatterns.Creational.FactoryMethod.Model;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class DbSqlFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
