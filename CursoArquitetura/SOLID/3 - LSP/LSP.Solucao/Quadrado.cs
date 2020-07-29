using System;

namespace SOLID._3___LSP.LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura)
            : base(altura, largura)
        {
            if (largura != altura)
            {
                throw new Exception("Os dois lados do quadrado precisam ser iguais.");
            }
        }
    }
}
