namespace DemoDi.Casos.Generics
{
    public interface IRepositorioGenerico<T> where T : class
    {
        void Adicionar(T obj);
    }
}
