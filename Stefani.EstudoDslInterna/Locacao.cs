using System;
using System.Collections.Generic;

namespace Stefani.EstudoDslInterna
{
    public class Locacao
    {
        public Locacao(Cliente cliente)
        {
            Cliente = cliente;
            RelacaoVideo = new List<Video>();
        }

        public DateTime DataDevolucao { get; private set; }
        public bool Pago { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<Video> RelacaoVideo { get; private set; }
        public decimal Total ()
        {
            if (!Pago)            
                return RelacaoVideo.Count * 2;
            
            return 0;
        }

        public static Locacao Para(Cliente cliente)
        {
            return new Locacao(cliente);
        }

        public Locacao Adicionar(Video video)
        {
            RelacaoVideo.Add(video);
            return this;
        }

        public Locacao Adicionar(List<Video> videos)
        {
            foreach (var item in videos)
            {
                Adicionar(item);
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
    }
}
