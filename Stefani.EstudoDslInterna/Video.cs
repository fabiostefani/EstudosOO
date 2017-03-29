using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefani.EstudoDslInterna
{
    public class Video
    {
        public string Nome { get; private set; }
        public string Genero { get; private set; }
        public string Elenco { get; private set; }
        public string Sinopse { get; private set; }
        public string NomeOriginal { get; private set; }

        public Video(String nome)
        {
            this.Nome = nome;
        }
        public Video SetarNomeOriginal(String nome)
        {
            NomeOriginal = nome;
            return this;
        }
        public Video DoGenero(String genero)
        {
            this.Genero = genero;
            return this;
        }
        public Video Com(String elenco)
        {
            this.Elenco = elenco;
            return this;
        }
        public Video PequenoResumo(String resumo)
        {
            this.Sinopse = resumo;
            return this;
        }
    }
}
