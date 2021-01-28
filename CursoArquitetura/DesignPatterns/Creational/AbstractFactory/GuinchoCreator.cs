using DesignPatterns.Creational.AbstractFactory.Model;
using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class GuinchoCreator
    {
        public static Guincho Criar(EnumPorte porte)
        {
            switch (porte)
            {
                case EnumPorte.Pequeno:
                    return new GuinchoPequeno(porte);
                case EnumPorte.Medio:
                    return new GuinchoMedio(porte);
                case EnumPorte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new ApplicationException("Porte de Guincho desconhecido.");
            }
        }
    }
}
