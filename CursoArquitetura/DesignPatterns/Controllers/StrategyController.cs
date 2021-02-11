using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Creational.FactoryMethod;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Controllers
{
    public class StrategyController : Controller
    {
        private readonly IPagamentoFactory _pagamentoFactory;

        public StrategyController(IPagamentoFactory pagamentoFactory)
        {
            _pagamentoFactory = pagamentoFactory;
        }
        public string Index()
        {
            Eventos.LimparDados();
            var produtos = new List<Produto>
            {
                new Produto{Nome = "Tenis Adidas", Valor = new Random().Next(500)},
                new Produto{Nome = "Camisa Boliche", Valor = new Random().Next(500)},
                new Produto{Nome = "Raquete Tenis", Valor = new Random().Next(500)}
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var meioPagamentoCredito = new Pagamento
            {
                MeioPagamento = MeioPagamento.CartaoCredito,
                CartaoCredito = "5555 2222 5555 9999"
            };

            var meioPagamentoBoleto = new Pagamento
            {
                MeioPagamento = MeioPagamento.Boleto
            };

            var meioPagamentoTransferencia = new Pagamento
            {
                MeioPagamento = MeioPagamento.TransferenciaBancaria
            };

            //#region Forma Simples

            //var pedidoCredito = new PedidoService(
            //                       new PagamentoCartaoCreditoService(
            //                       new PagamentoCartaoCreditoFacade(
            //                       new PayPalGateway(),
            //                       new ConfigurationManager())));
            //var pagamentoCredito = pedidoCredito.RealizarPagamento(pedido, meioPagamentoCredito);
            //Console.WriteLine(pagamentoCredito.Status);

            //Console.WriteLine("-------------------------------------------------------");

            //var pedidoBoleto = new PedidoService(
            //                       new PagamentoBoletoService(
            //                       new PagamentoBoletoFacade()));

            //var pagamentoBoleto = pedidoBoleto.RealizarPagamento(pedido, meioPagamentoBoleto);
            //Console.WriteLine(pagamentoBoleto.Status);

            //Console.WriteLine("-------------------------------------------------------");

            //var pedidoTransferencia = new PedidoService(
            //                              new PagamentoTransferenciaService(
            //                              new PagamentoTransferenciaFacade()));

            //var pagamentoTransferencia = pedidoTransferencia.RealizarPagamento(pedido, meioPagamentoBoleto);
            //Console.WriteLine(pagamentoTransferencia.Status);

            //Console.WriteLine("-------------------------------------------------------");

            //#endregion

            #region Forma Elegante

            var pedidoCredito2 = new PedidoService(_pagamentoFactory.CreatePagamento(meioPagamentoCredito.MeioPagamento));
            var pagamentoCredito2 = pedidoCredito2.RealizarPagamento(pedido, meioPagamentoCredito);

            var pedidoBoleto2 = new PedidoService(_pagamentoFactory.CreatePagamento(meioPagamentoBoleto.MeioPagamento));
            var pagamentoBoleto2 = pedidoBoleto2.RealizarPagamento(pedido, meioPagamentoBoleto);

            var pedidoTransferencia2 = new PedidoService(_pagamentoFactory.CreatePagamento(meioPagamentoTransferencia.MeioPagamento));
            var pagamentoTransferencia2 = pedidoTransferencia2.RealizarPagamento(pedido, meioPagamentoTransferencia);

            #endregion
            return Eventos.Imprimir();
        }
    }
}
