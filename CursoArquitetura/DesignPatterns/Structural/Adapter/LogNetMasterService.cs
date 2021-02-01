using DesignPatterns.Creational.FactoryMethod;
using System;

namespace DesignPatterns.Structural.Adapter
{
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Eventos.Adicionar($"Log customizado - {message}");
        }
        public void LogException(Exception exception)
        {
            Eventos.Adicionar($"Log customizado - {exception.Message}");
        }
    }
}
