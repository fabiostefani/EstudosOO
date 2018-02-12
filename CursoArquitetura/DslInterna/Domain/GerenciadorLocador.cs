using System;

namespace DslInterna.Domain
{
    public class GerenciadorLocador
    {
        public static void Imprimir(Locacao locacao)
        {
            Console.WriteLine($"Nome {locacao.Cliente.Nome}");
            foreach (var item in locacao.RelacaoVideo)
            {
                Console.WriteLine($"{item.Nome}-{item.Genero}."); //string interpolation
                //Console.WriteLine(string.Format("{0}-{1}.", item.Nome, item.Genero));
            }

            Console.WriteLine($"Total R$ {locacao.ObterTotal()}.");
            //Console.WriteLine(string.Format("Devolver em {0}.", locacao.DataDevolucao));
            Console.WriteLine($"Devolver em {locacao.DataDevolucao}.");
            Console.WriteLine("Assinatura:_____________________________");
        }
    }
}
