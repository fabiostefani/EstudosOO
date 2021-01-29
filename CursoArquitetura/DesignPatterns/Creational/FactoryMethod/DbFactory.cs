using DesignPatterns.Creational.FactoryMethod.Model;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectionString);
        public static DbFactory DataBase(EnumDataBase dataBase)
        {
            return DbFactoryCreator.Create(dataBase);
        }
    }
}
