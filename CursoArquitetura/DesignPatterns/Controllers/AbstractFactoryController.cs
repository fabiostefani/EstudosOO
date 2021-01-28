using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Controllers
{
    public class AbstractFactoryController : Controller
    {
        public string Index()
        {
            var strRetorno = new StringBuilder();
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Celta", EnumPorte.Pequeno),
                VeiculoCreator.Criar("Jetta", EnumPorte.Medio),
                VeiculoCreator.Criar("BMW X6", EnumPorte.Grande)
            };

            veiculosSocorro.ForEach(v => strRetorno.AppendLine(AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento()));
            return strRetorno.ToString();
        }
    }
}
