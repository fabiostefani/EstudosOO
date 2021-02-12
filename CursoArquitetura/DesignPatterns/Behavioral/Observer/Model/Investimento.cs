using DesignPatterns.Creational.FactoryMethod;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer.Model
{
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObservador> _observadores = new List<IObservador>();

        protected Investimento(string simbolo, decimal valor)
        {
            Simbolo = simbolo;
            _valor = valor;
        }

        public string Simbolo { get; }
        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) return;

                _valor = value;
                Notificar();
            }
        }


        public void Subscribe(IObservador observador)
        {
            _observadores.Add(observador);
            Eventos.Adicionar($"Notificando que {observador.Nome} está recebendo atualizãções de {Simbolo}");
        }

        public void UnSubscribe(IObservador observador)
        {
            _observadores.Remove(observador);
            Eventos.Adicionar($"Notificando que {observador.Nome} NÃO está recebendo atualizãções de {Simbolo}");
        }

        private void Notificar()
        {
            foreach (var investor in _observadores)
            {
                investor.Notificar(this);
            }

            Console.WriteLine("");
        }
    }
}
