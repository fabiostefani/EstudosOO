using SOLID._2___OCP.OCP.SolucaoExtensionMethods;
using SOLID._3___LSP.LSP.Solucao;
//using SOLID._3___LSP.LSP.Violacao;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuOperacoes();
            var opcao = Console.ReadKey();
            switch (opcao.KeyChar)
            {
                case '1':
                    var caixa = new CaixaEletronico();
                    caixa.Operacoes();
                    break;
                case '2':
                    //Violacao
                    //CalculoArea.Calcular();

                    //Solução
                    CalculoArea.Calcular();
                    break;
                default:
                    break;
            }
        }

        private static void MenuOperacoes()
        {
            Console.Clear();
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine();
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");

        }
    }
}
