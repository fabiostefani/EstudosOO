namespace DesignPatterns.Behavioral.Strategy
{
    public interface IPagamentoCartaoCreditoFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
