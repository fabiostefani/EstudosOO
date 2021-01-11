namespace SOLID._5___DIP.DIP.Solução.Interfaces
{
    public interface IEmailService
    {
        void Enviar(string origem, string email, string bemVindo, string corpo);
    }
}
