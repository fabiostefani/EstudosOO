namespace Stefani.CursoArquitetura.OO._3___Abstracao
{
    public abstract class Eletromestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletromestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();
    }
}
