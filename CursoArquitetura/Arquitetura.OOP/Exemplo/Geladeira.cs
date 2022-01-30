namespace Arquitetura.OOP.Exemplo
{
    public class Geladeira : Eletrodomestico
    {
        public override bool Ligar()
        {
            Ligado = true;
            IniciarRegrigeracao();
        }

        public override bool Desligar() => Ligado = false;        
    }

    public class Objeto
    {
        public Objeto()
        {
            var geladeira = new Geladeira();
            geladeira.Ligar();
        }
    }
}