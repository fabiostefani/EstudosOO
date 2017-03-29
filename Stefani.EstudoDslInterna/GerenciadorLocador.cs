using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefani.EstudoDslInterna
{
    public static class GerenciadorLocador
    {
        public static void Imprimir(Locacao suaLocacao)
        {
            Console.WriteLine("Nome: " + suaLocacao.Cliente.Nome);
            foreach (var video in suaLocacao.RelacaoVideo)
            {
                Console.WriteLine(video.Nome + " - " + video.Genero);
            }

            Console.WriteLine("Total: R$ " + suaLocacao.Total());
            Console.WriteLine("Devolver em " + suaLocacao.DataDevolucao);
            Console.WriteLine("Assinatura:________");
        }
    }
}
