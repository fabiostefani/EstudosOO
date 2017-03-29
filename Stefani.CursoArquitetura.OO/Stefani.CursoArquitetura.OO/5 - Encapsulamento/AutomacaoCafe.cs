using Stefani.CursoArquitetura.OO._4___Polimorfismo;

namespace Stefani.CursoArquitetura.OO._5___Encapsulamento
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.FazerCafe();
            espresso.Desligar();
        }
    }
}
