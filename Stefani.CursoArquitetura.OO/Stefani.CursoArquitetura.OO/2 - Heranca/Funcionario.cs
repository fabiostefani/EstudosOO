using Stefani.CursoArquitetura.OO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stefani.CursoArquitetura.OO.Heranca
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }

    }

    public class Processo
    {
        public static void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "João da Silva",
                DataAdmissao = DateTime.Now,
                DataNascimento = new DateTime(1984, 03, 08),
                Registro = "0123456789"
            };
        }
    }
}
