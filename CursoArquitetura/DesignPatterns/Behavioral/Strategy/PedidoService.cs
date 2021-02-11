using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PedidoService
    {
        private readonly IPagamento _pagamento;

        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            var statusPagamento = _pagamento.RealizarPagamento(pedido, pagamento);
            Eventos.Adicionar(statusPagamento.Status);
            return statusPagamento;
        }
    }
}
