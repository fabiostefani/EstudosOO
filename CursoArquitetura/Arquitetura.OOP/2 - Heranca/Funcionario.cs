using System;

namespace Arquitetura.OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Fabio",
                DataNascimento = Convert.ToDateTime("1900,01,01"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456"
            };

            funcionario.CalcularIdade();
        }
    }
}