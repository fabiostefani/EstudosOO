namespace SOLID._2___OCP.OCP.SolucaoExtensionMethods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            //lógica de negócio para débito em poupança.
            return debitoConta.FormatarTransacao();
        }
    }
}
