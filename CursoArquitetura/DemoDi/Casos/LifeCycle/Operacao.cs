﻿using System;

namespace DemoDi.Casos.LifeCycle
{
    public class Operacao : IOperacaoTransient, IOperacaoScoped, IOperacaoSingleton, IOperacaoSingletonInstance
    {
        public Operacao() : this(Guid.NewGuid())
        {

        }

        public Operacao(Guid id)
        {
            OperacaoId = id;
        }

        public Guid OperacaoId { get; private set; }
    }
}
