using System;

namespace Arquitetura.OOP
{
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem)
        {
        }

        public CafeteiraEspressa()
            : base("Padrão", 220)
        {

        }

        public override void Desligar()
        {
            //lógica do método Desligar
        }

        public static void FazerCafe()
        {
            AquecerAgua();
            MoerGraos();
        }

        public override void Ligar()
        {
            //lógica do método desligar
        }

        private static void AquecerAgua()
        {
        }

        private static void MoerGraos()
        {

        }
    }
}
