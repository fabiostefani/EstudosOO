using DesignPatterns.Creational.AbstractFactory.Model;
using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, EnumPorte porte)
        {
            switch (porte)
            {
                case EnumPorte.Pequeno:
                    return new VeiculoPequeno(modelo, porte);
                case EnumPorte.Medio:
                    return new VeiculoMedio(modelo, porte);
                case EnumPorte.Grande:
                    return new VeiculoGrande(modelo, porte);
                default:
                    throw new ApplicationException("Porte de veiculo desconhecido.");
            }
        }
    }
}
