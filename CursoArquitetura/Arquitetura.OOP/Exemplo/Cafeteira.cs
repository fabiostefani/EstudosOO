namespace Arquitetura.OOP.Exemplo
{
    public class Cafeteira : Eletrodomestico
    {
        public override bool Ligar() => Ligado = true;        
        public override bool Desligar() => Ligado = false;     

        public void FazerCafe()
        {
            Ligar();
            AquecerAgua();
            Coar();
            Desligar();
        }           
    }

    public class ObjetoCafeteira
    {
        public Cafeteira()
        {
            var cafeteira = new Cafeteira();
            cafeteira.FazerCafe();
        }
    }
}