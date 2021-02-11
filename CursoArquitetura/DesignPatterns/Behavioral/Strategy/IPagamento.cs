namespace DesignPatterns.Behavioral.Strategy
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
