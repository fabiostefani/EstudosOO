using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Structural.Composite.Model
{
    public class InputFormMessage : IMessage
    {
        public string Nome { get; set; }

        public InputFormMessage(string name)
        {
            Nome = name;
        }
        public void ExibirMensagens(int sub)
        {
            Eventos.Adicionar(new string('-', sub) + Nome);
        }
    }
}
