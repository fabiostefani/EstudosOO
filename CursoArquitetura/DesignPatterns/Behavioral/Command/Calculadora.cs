using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Behavioral
{
    internal class Calculadora
    {
        private int _valorAtual;

        public void Operacao(char operador, int valor)
        {
            switch (operador)
            {
                case '+': _valorAtual += valor; break;
                case '-': _valorAtual -= valor; break;
                case '*': _valorAtual *= valor; break;
                case '/': _valorAtual /= valor; break;
            }
            Eventos.Adicionar($"(dado {operador} {valor}) - Valor atual = {_valorAtual}");
        }
    }
}
