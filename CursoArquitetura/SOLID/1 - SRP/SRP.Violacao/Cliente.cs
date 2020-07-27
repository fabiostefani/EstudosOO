using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID._1___SRP.SRP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
            {
                return "Cliente com e-mail inválido";
            }

            if (Cpf.Length != 11)
            {
                return "Cliente com CPF inválido.";
            }

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (nome, email, cpf, datacadastro)";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", Cpf);
                cmd.Parameters.AddWithValue("datacadastro", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("empresa@empresa.com", Email);
            var cliente = new SmtpClient()
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem vindo";
            mail.Body = "Parabéns! VOcê está cadastrado.";

            cliente.Send(mail);

            return "Cliente cadastrado com sucesso.";
            ;
        }


    }
}
