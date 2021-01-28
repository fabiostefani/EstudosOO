namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(EnumPorte porte) : base(porte)
        {

        }

        public override string Socorrer(Veiculo veiculo)
        {
            return $"Socorrendo Carro Médio - Modelo {veiculo.Modelo}";
        }
    }
}
