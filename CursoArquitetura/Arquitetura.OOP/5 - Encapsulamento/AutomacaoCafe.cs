namespace Arquitetura.OOP
{
    public class AutomacaoCafe
    {
        public static void ServirCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            CafeteiraEspressa.FazerCafe();
            espresso.Desligar();
        }
    }
}
