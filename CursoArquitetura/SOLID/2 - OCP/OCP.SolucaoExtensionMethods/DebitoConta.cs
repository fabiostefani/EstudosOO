using System;
using System.Linq;

namespace SOLID._2___OCP.OCP.SolucaoExtensionMethods
{
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public decimal Valor { get; set; }
        public string NumeroTransacao { get; set; }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVXWYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(x => x[random.Next(x.Length)]).ToArray());

            return NumeroTransacao;
        }
    }
}
