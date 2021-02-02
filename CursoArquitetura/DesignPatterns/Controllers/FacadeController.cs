using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Structural.Facade.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Controllers
{
    public class FacadeController : Controller
    {
        private readonly IPagamento _pagamentoService;

        public FacadeController(IPagamento pagamento)
        {
            _pagamentoService = pagamento;
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

            var pagamento = new Pagamento
            {
                CartaoCredito = "5555 2222 5555 9999"
            };

            var pagamentoResult = _pagamentoService.RealizarPagamento(pedido, pagamento);
            Eventos.Adicionar(pagamentoResult.Status);
            return Eventos.Imprimir();
        }
    }
}
