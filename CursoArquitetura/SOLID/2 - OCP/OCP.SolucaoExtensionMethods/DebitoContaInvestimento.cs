namespace SOLID._2___OCP.OCP.SolucaoExtensionMethods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            //lógica de negócio para débito investimento
            return debitoConta.FormatarTransacao();
        }
    }
}
