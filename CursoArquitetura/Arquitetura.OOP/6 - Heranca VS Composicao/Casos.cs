using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.OOP._6___Heranca_VS_Composicao
{
    public class PessoaFisica : Pessoa // CASO DE HERANÇA
    {
        public string Cpf { get; set; }
    }

    public class PessoFisica2 //CASO DE COMPOSIÇÃO
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Fabio",
                DataNascimento  =DateTime.Now,
                Cpf = "12345678900"
            };

            var pessoaComposicao = new PessoFisica2
            {
                Pessoa = new Pessoa()
                {
                    Nome = "Fabio",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "12345678900"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;

        }
    }
}
