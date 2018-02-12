using System;
using System.Collections.Generic;

namespace DslInterna.Domain
{
    public class Locacao
    {
        public Cliente Cliente { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool Pago { get; set; }
        public List<Video> RelacaoVideo { get; set; }

        private Locacao(Cliente cliente)
        {
            Cliente = cliente;
            RelacaoVideo = new List<Video>();
        }

        public static Locacao Para(Cliente cliente)
        {
            return new Locacao(cliente);
        }

        public Locacao Adicionar(params Video[] videos)
        {
            foreach (var item in videos)
            {
                RelacaoVideo.Add(item);
            }

            return this;
        }

        public Locacao ParaDevolver(DateTime data)
        {
            DataDevolucao = data;
            return this;
        }

        public Locacao APagar()
        {
            Pago = false;
            return this;
        }

        public Locacao JaPago()
        {
            Pago = true;
            return this;
        }

        public string ObterTotal()
        {
            return !Pago ? (RelacaoVideo.Count * 2).ToString("##0.00") : "0.00";
        }
    }
}
