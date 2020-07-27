namespace SOLID._2___OCP.OCP.SolucaoExtensionMethods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            //lógica de negócio para débito em conta corrente.
            return debitoConta.FormatarTransacao();
        }
    }
}
