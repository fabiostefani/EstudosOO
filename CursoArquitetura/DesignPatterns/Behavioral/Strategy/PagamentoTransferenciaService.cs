﻿using DesignPatterns.Creational.FactoryMethod;
using System.Linq;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoTransferenciaService : IPagamento
    {
        private readonly IPagamentoTransferenciaFacade _pagamentoTransferenciaFacade;

        public PagamentoTransferenciaService(IPagamentoTransferenciaFacade pagamentoTransferenciaFacade)
        {
            _pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Eventos.Adicionar($"Iniciando Pagamento via Transferência - Valor R$ {pagamento.Valor}");
            pagamento.ConfirmacaoTransferencia = _pagamentoTransferenciaFacade.RealizarTransferencia();
            pagamento.Status = "Pago via Transferência";
            return pagamento;
        }
    }
}
