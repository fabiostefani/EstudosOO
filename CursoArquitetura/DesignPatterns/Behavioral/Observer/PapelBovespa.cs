using DesignPatterns.Behavioral.Observer.Model;

namespace DesignPatterns.Behavioral.Observer
{
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal preco)
            : base(simbolo, preco)
        {
        }
    }
}
