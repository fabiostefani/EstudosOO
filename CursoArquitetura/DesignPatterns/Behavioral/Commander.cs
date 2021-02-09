namespace DesignPatterns.Behavioral
{
    internal abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
