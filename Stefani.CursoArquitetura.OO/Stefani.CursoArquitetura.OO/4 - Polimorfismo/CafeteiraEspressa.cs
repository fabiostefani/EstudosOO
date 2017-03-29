using Stefani.CursoArquitetura.OO._3___Abstracao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stefani.CursoArquitetura.OO._4___Polimorfismo
{
    public class CafeteiraEspressa : Eletromestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem)
        {
        }

        public CafeteiraEspressa()
            :base("Padrão", 220)
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
            
        }

        public override void Ligar()
        {
            
        }
    }
}
