using System;

namespace SOLID._4___ISP.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            throw new NotImplementedException("ESTE MÉTODO NÃO FAZ NADA");
        }

        public void SalvarBanco()
        {
            //salvar no banco
        }

        public void ValidarDados()
        {
            //validar dados
        }
    }
}
