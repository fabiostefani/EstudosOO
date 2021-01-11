namespace SOLID._4___ISP.ISP.Solução
{
    public interface ICadastroProduto : ICadastro, IConsulta
    {
        void ValidarDados();
    }
}
