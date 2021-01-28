namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(EnumPorte porte) : base(porte)
        {

        }

        public override string Socorrer(Veiculo veiculo)
        {
            return $"Socorrendo Carro Pequeno - Modelo {veiculo.Modelo}";
        }
    }
}
