using DesignPatterns.Creational.AbstractFactory.Model;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculos(string modelo, EnumPorte porte);
    }
}
