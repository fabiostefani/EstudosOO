using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public static class Eventos
    {
        public static List<string> Evento = new List<string>();

        public static void Adicionar(string mensagem)
        {
            Evento.Add(mensagem);
        }

        public static void LimparDados()
        {
            Evento.Clear();
        }

        public static string Imprimir()
        {
            var str = new StringBuilder();
            Evento.ForEach(x => str.AppendLine(x));
            return str.ToString();
        }
    }
}
