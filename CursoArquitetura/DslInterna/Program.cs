using DslInterna.Domain;
using DslInterna.Infra;
using System;

namespace DslInterna
{
    public class Program
    {
        public static void Main()
        {
            var paulo = new Cliente("19784567891", "Paulo");
            var locacao = Locacao.Para(paulo);


            var tropaDeElite = new Video("Tropa da Elite")
                .ComNomeOriginal("Tropa de Elite")
                .DoGenero("ação/crime/drama")
                .Com("Wagner Moura, Caio Junqueira....")
                .PequenoResumo("Filme que retrata o trabalho do B.O.P.E em ação.");

            var osSimpsons = new Video("Os Simpsons")
                .ComNomeOriginal("Os Simpsons")
                .DoGenero("animação/comédia")
                .Com("Homer, Marge, Lisa, Bart....")
                .PequenoResumo("A família mais querida do mundo agora em um longa metragem.");

            locacao.Adicionar(tropaDeElite, osSimpsons)
                .ParaDevolver(DataUtil.DaquiA(DataUtil.DOIS_DIAS))
                .APagar();

            GerenciadorLocador.Imprimir(locacao);
            Console.ReadKey();


            var fabio = new Cliente("19784567891", "Fabio");
            var locacao2 = Locacao.Para(fabio);

            locacao2.Adicionar(tropaDeElite, osSimpsons)
                .ParaDevolver(DataUtil.DaquiA(DataUtil.QUATRO_DIAS))
                .JaPago();

            GerenciadorLocador.Imprimir(locacao2);
            Console.ReadKey();
        }
    }
}
