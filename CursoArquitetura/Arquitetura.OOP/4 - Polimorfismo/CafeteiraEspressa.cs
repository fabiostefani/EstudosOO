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
            :base("Padrão",220)
        {

        }

        private static void AquecerAgua()
        {
        }

        private static void MoerGraos()
        {

        }

        public void FazerCafe()
        {
            AquecerAgua();
            MoerGraos();
        }

        public override void Desligar()
        {
            //lógica do método Desligar
        }

        public override void Ligar()
        {
            //lógica do método desligar
        }
    }
}
