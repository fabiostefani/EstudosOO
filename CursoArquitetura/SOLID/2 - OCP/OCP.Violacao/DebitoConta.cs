namespace SOLID._2___OCP.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, EnumTipoConta tipoConta)
        {
            if (tipoConta == EnumTipoConta.Corrente)
            {
                //Debita Conta Corrente
            }

            if (tipoConta == EnumTipoConta.Poupanca)
            {
                //Validar aniversário da Conta
                //Debita Conta Poupança
            }
        }
    }
}
