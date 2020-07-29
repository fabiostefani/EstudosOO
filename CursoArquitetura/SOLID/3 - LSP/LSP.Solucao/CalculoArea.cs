using System;

namespace SOLID._3___LSP.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Paralelogramo paralelograma)
        {
            Console.WriteLine("Cálculo da área");
            Console.WriteLine();
            Console.WriteLine(paralelograma.Altura + " * " + paralelograma.Largura);
            Console.WriteLine();
            Console.WriteLine(paralelograma.Area);

        }

        public static void Calcular()
        {
            var quad = new Quadrado(5, 5);

            ObterAreaRetangulo(quad);

            var ret = new Retangulo(10, 5);

            ObterAreaRetangulo(ret);

            Console.ReadKey();
        }
    }
}
