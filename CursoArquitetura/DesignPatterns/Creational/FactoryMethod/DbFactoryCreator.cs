using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class DbFactoryCreator
    {
        public static DbFactory Create(EnumDataBase dataBase)
        {
            switch (dataBase)
            {
                case EnumDataBase.SqlServer:
                    return new DbSqlFactory();
                case EnumDataBase.Oracle:
                    return new DbOracleFactory();
                default:
                    throw new ApplicationException("Banco de dados não reconhecido.");
            }
        }
    }
}
