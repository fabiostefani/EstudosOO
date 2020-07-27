using System.Data;
using System.Data.SqlClient;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class ClienteRepository
    {
        public string AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (nome, email, cpf, datacadastro)";

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("datacadastro", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            return "Cliente cadastrado com sucesso.";
        }
    }
}
