namespace Arquitetura.OOP.Exemplo
{
    public class Televisao : Eletrodomestico
    {
        public override bool Ligar()
        {
            Ligado = true;
            IniciarTransmicaoImagem();
        }
        
        public override bool Desligar() => Ligado = false;        
    }

    public class PolimorfismoExemplo
    {
public void Polimorfismo()
{
    List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>() 
    { 
        new Geladeira(), 
        new Cafeteira(), 
        new Televisao() 
    };                        
    foreach (var eletro in eletrodomesticos)
    {
        eletro.Ligar();
    }
}   
    }
}