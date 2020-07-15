using System;

namespace Arquitetura.OOP
{
    public class Pessoa
    {
        //ESTADO É REPRESENTADO ATRAVÉS DAS PROPS
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //COMPORTAMENTO É REPRESENTADO ATRAVÉS DE MÉTODOS DENTRO DA PRÓPRIA CLASSE
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;
            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }   
}
