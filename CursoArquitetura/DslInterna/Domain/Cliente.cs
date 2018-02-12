namespace DslInterna.Domain
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }

        public Cliente(string cpf, string nome)
        {
            Cpf = cpf;
            Nome = nome;
        }
    }
}
