namespace DesignPatterns.Behavioral.Strategy
{
    public interface IPagamentoFactory
    {
        IPagamento CreatePagamento(MeioPagamento meioPagamento);
    }
}
