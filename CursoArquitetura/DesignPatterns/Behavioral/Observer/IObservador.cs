﻿using DesignPatterns.Behavioral.Observer.Model;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
