namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(EnumPorte porte) : base(porte)
        {

        }

        public override string Socorrer(Veiculo veiculo)
        {
            return $"Socorrendo Carro Grande - Modelo {veiculo.Modelo}";
        }
    }
}
