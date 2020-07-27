using System;
using System.Linq;

namespace SOLID._2___OCP.OCP.Solucao
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public abstract string Debitar(decimal valor, string conta);

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
