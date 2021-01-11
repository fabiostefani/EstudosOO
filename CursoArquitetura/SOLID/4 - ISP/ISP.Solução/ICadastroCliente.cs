namespace SOLID._4___ISP.ISP.Solução
{
    public interface ICadastroCliente : ICadastro, IConsulta
    {
        void EnviarEmail();
        void ValidarDados();
        void Recupear();
    }
}
