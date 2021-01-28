namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public abstract class Veiculo
    {
        protected Veiculo(string modelo, EnumPorte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; set; }
        public EnumPorte Porte { get; set; }
    }
}
