using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefani.EstudoDslInterna
{
    class Program
    {
        static void Main()
        {
            var paulo = new Cliente("12345678960", "Paulo");
            var locacao = Locacao.Para(paulo);

            var videos = new List<Video>();

            videos.Add(
                new Video("Tropa de Elite")
                .SetarNomeOriginal("Tropa de Elite")
                .DoGenero("ação / crime / drama")
                .Com("Wagner Moura, Caio Junqueira...")
                .PequenoResumo("Filme retrata o trabalho do B.O.P.E. em ação..."));

            videos.Add(
                new Video("Os Simpsos")
                .SetarNomeOriginal("Os Simpsos")
                .DoGenero("Comédia")
                .Com("Homer")
                .PequenoResumo("só pra rir"));

            locacao.Adicionar(videos)
                .ParaDevolver(DataUtil.DaquiA(DataUtil.DOIS_DIAS))
                .APagar();

            GerenciadorLocador.Imprimir(locacao);

            Console.ReadKey();
        }
    }
}
