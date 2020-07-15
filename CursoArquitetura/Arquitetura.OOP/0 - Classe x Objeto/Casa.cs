namespace Arquitetura.OOP._0___Classe_x_Objeto
{
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa()
            {
                Andares = 2,
                NumeroVagas = 2,
                TamanhoM2 = 100,
                Valor = 100000
            };
        }
    }
}
