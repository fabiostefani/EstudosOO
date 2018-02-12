namespace Arquitetura.OOP
{
    //abstração não é o fato de criar classes abstratas, mas trazer o mundo real para dentro da programação.

    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();

        public abstract void Desligar();
    }
}
