namespace Arquitetura.OOP.Exemplo
{
    public abstract class Eletrodomestico
    {
        public int Voltagem { get; set; }
        public int NumeroSerie { get; set; }
        public bool Ligado { get; private set; }
        
        public abstract bool Ligar();
        public abstract bool Desligar();
    }
}