using DesignPatterns.Creational.AbstractFactory.Model;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AutoSocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(EnumPorte.Grande);
        }

        public override Veiculo CriarVeiculos(string modelo, EnumPorte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
