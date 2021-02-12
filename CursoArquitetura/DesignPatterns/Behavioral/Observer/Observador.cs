using DesignPatterns.Behavioral.Observer.Model;
using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Behavioral.Observer
{
    internal class Observador : IObservador
    {
        public Observador(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }

        public void Notificar(Investimento investimento)
        {
            Eventos.Adicionar($"Notificando {Nome} que {investimento.Simbolo} teve preço alterado para {investimento.Valor}");
        }


    }
}
