namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public abstract class Guincho
    {
        protected Guincho(EnumPorte porte)
        {
            Porte = porte;
        }
        public abstract string Socorrer(Veiculo veiculo);
        public EnumPorte Porte { get; set; }
    }
}
