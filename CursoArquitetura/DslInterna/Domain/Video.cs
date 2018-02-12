namespace DslInterna.Domain
{
    public class Video
    {
        public string Nome { get; private set; }
        public string NomeOriginal { get; private set; }
        public string Genero { get; private set; }
        public string Elenco { get; private set; }
        public string Sinopse { get; private set; }

        public Video(string nome)
        {
            Nome = nome;
        }

        public Video ComNomeOriginal(string nomeOriginal)
        {
            NomeOriginal = nomeOriginal;
            return this;
        }

        public Video DoGenero(string genero)
        {
            Genero = genero;
            return this;
        }

        public Video Com(string elenco)
        {
            Elenco = elenco;
            return this;
        }

        public Video PequenoResumo(string resumo)
        {
            Sinopse = resumo;
            return this;
        }
    }
}
