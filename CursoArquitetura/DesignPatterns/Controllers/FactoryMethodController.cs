using DesignPatterns.Creational.FactoryMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    public class FactoryMethodController : Controller
    {
        public string Index()
        {
            Eventos.LimparDados();
            var sqlCn = DbFactory.DataBase(EnumDataBase.SqlServer)
                                 .CreateConnector("minhaCS")
                                 .Connect();

            sqlCn.ExecuteCommand("select * from tabelaSql");
            sqlCn.Close();

            Eventos.Adicionar("");
            Eventos.Adicionar("--------------------------------");
            Eventos.Adicionar("");

            var oracleCn = DbFactory.DataBase(EnumDataBase.Oracle)
                                    .CreateConnector("minhaCS")
                                    .Connect();

            oracleCn.ExecuteCommand("select * from tabelaOracle");
            oracleCn.Close();
            return Eventos.Imprimir();
        }
    }
}
