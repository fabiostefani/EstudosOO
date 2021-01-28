using DesignPatterns.Creational.AbstractFactory.Model;
using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AutoSocorro
    {
        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;
        public AutoSocorro(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculos(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public string RealizarAtendimento()
        {
            return _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            switch (veiculo.Porte)
            {
                case EnumPorte.Pequeno:
                    return new AutoSocorro(new AutoSocorroVeiculoPequenoFactory(), veiculo);
                case EnumPorte.Medio:
                    return new AutoSocorro(new AutoSocorroVeiculoMedioFactory(), veiculo);
                case EnumPorte.Grande:
                    return new AutoSocorro(new AutoSocorroVeiculoGrandeFactory(), veiculo);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }
    }
}
