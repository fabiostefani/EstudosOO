using System.Net.Mail;

namespace SOLID._5___DIP.DIP.Violacao
{
    public static class EmailService
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public static void Enviar(string origem, string email, string bemVindo, string corpo)
        {
            var mail = new MailMessage(origem, email);
            var cliente = new SmtpClient()
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = bemVindo;
            mail.Body = corpo;

            cliente.Send(mail);
        }
    }
}
