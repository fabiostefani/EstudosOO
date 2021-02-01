using DesignPatterns.Creational.FactoryMethod;
using System;

namespace DesignPatterns.Structural.Adapter
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Eventos.Adicionar($"Log padrão - {message}");
        }

        public void LogError(Exception exception)
        {
            Eventos.Adicionar($"Log padrão - {exception.Message}");
        }
    }
}
