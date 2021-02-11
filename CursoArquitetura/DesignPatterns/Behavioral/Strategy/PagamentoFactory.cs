using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoFactory : IPagamentoFactory
    {
        //private readonly IServiceProvider _serviceProvider;
        private readonly IPagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;
        private readonly IPagamentoBoletoFacade _pagamentoBoletoFacade;
        private readonly IPagamentoTransferenciaFacade _pagamentoTransferenciaFacade;

        public PagamentoFactory(/*IServiceProvider serviceProvider,*/
                                IPagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade,
                                IPagamentoBoletoFacade pagamentoBoletoFacade,
                                IPagamentoTransferenciaFacade pagamentoTransferenciaFacade)
        {
            //_serviceProvider = serviceProvider;
            _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
            _pagamentoBoletoFacade = pagamentoBoletoFacade;
            _pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;
        }

        public IPagamento CreatePagamento(MeioPagamento meioPagamento)
        {
            switch (meioPagamento)
            {
                case MeioPagamento.CartaoCredito:
                    //var pagtoCartaoService = _serviceProvider.GetService<IPagamentoCartaoCreditoFacade>();
                    return new PagamentoCartaoCreditoService(_pagamentoCartaoCreditoFacade);

                case MeioPagamento.Boleto:
                    //var pagtoBoletoService = _serviceProvider.GetService<IPagamentoBoletoFacade>();
                    return new PagamentoBoletoService(_pagamentoBoletoFacade);

                case MeioPagamento.TransferenciaBancaria:
                    //var pagtoTransfService = _serviceProvider.GetService<IPagamentoTransferenciaFacade>();
                    return new PagamentoTransferenciaService(_pagamentoTransferenciaFacade);

                default:
                    throw new ApplicationException("Meio de Pagamento não conhecido");
            }
        }
    }
}
