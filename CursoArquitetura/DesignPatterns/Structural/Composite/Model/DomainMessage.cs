using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Structural.Composite.Model
{
    public class DomainMessage : IMessage
    {
        public string Nome { get; set; }

        public DomainMessage(string name)
        {
            Nome = name;
        }

        public void ExibirMensagens(int sub)
        {
            Eventos.Adicionar(new string('-', sub) + Nome);

        }
    }
}
